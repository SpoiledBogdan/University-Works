using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Kurs1
{
	public partial class InputForm : Form
	{
		public string filename = "";
		public static string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
		public OleDbConnection connection = new OleDbConnection(con);
		public List<string> columns;
		public List<string> parameters;
		public List<System.Windows.Forms.Label> labels;
		public List<System.Windows.Forms.TextBox> textboxes;
		public System.Windows.Forms.Button add;
		public DataGridView dgv;
		public int mode;
		public int code;
		public int table_number;
		public InputForm(string filename, DataGridView dgv, int mode, int table_number, int code = -1)
		{
			InitializeComponent();
			this.connection = new OleDbConnection(con + filename);
			this.dgv = dgv;
			this.mode = mode;
			this.table_number = table_number;
			this.columns = new List<string>();
			this.parameters = new List<string>();
			this.labels = new List<System.Windows.Forms.Label>();
			this.textboxes = new List<System.Windows.Forms.TextBox>();
			if (mode == 1) this.Text = "Добавление";
			if (mode == 2)
			{
				this.Text = "Редактирование";
				this.code = code;
				for (int i = 0; i < dgv.Rows.Count; i++)
				{
					if (dgv.Rows[i].Cells[0].Value.ToString() == this.code.ToString())
					{
						for (int j = 0; j < dgv.Rows[i].Cells.Count - 1; j++)
							parameters.Add(dgv.Rows[i].Cells[j + 1].Value.ToString());
						break;
					}
				}
			}
		}
		private void InputForm_Load(object sender, EventArgs e)
		{
			foreach (DataGridViewColumn dgvc in this.dgv.Columns)
				if (dgvc.Name != "Код")
				{
					this.columns.Add(dgvc.Name);
					this.labels.Add(new System.Windows.Forms.Label());
					this.textboxes.Add(new System.Windows.Forms.TextBox());
				}
			for (int i = 0; i < columns.Count; i++)
			{
				//labels
				this.labels[i].Text = columns[i];
				this.labels[i].Location = new Point(10, 20 + i * 50 + 25);
				this.labels[i].Font = new System.Drawing.Font("Consolas", 9F);
				this.labels[i].Width = 250;
				//textboxes
				this.textboxes[i].Location = new Point(10, 20 + i * 50);
				this.textboxes[i].Font = new System.Drawing.Font("Consolas", 11F);
				this.textboxes[i].Width = 250;
				if (this.mode == 2) this.textboxes[i].Text = this.parameters[i];
				//adding to program
				this.Controls.Add(labels[i]);
				this.Controls.Add(textboxes[i]);
			}
			this.add = new System.Windows.Forms.Button();
			if (mode == 1)
			{
				this.add.Text = "Добавить";
				this.add.Width = 90;
				this.add.Height = 30;
			}
			if (mode == 2)
			{
				this.add.Text = "Редактировать";
				this.add.Width = 120;
				this.add.Height = 40;
			}
			this.add.Font = new System.Drawing.Font("Consolas", 10F);
			this.add.Location = new Point(10, this.labels.Count * 50 + 25);
			this.add.Click += new System.EventHandler(this.add_Click);
			this.Controls.Add(this.add);
			this.Size = new System.Drawing.Size(320, (this.labels.Count + 2) * 50 + 20);
		}
		private void add_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.textboxes.Count; i++)
			{
				if (this.textboxes[i].Text.Length == 0)
				{
					MessageBox.Show($"Поле \"{this.columns[i]}\" пустое", "Ошибка");
					return;
				}
			}
			if (mode == 1)
			{
				string cls = "(";
				string vals = "(";
				for (int i = 0; i < this.columns.Count; i++)
				{
					cls += $"`{this.columns[i]}`,";
					vals += $"`@value{i}`,";
				}
				cls = cls.Substring(0, cls.Length - 1) + ")";
				vals = vals.Substring(0, vals.Length - 1) + ")";
				string str = table_number == 1 ? "Места прибытия и отбытия" : "День прилета и отлета";
				string cmd = $"INSERT INTO `{str}`{cls} VALUES {vals}";
				OleDbCommand command = new OleDbCommand(cmd, connection);
				for (int i = 0; i < this.columns.Count; i++)
					command.Parameters.Add($"@value{i}", OleDbType.VarChar).Value = this.textboxes[i].Text;

				connection.Open();
				try
				{
					if (command.ExecuteNonQuery() == 1) MessageBox.Show("Данные добавлены", "Добавление");
					else MessageBox.Show("Данные не добавлены", "Добавление");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				connection.Close();
			}
			if (mode == 2)
			{
				string cls = "";
				for (int i = 0; i < this.columns.Count; i++)
					cls += $"`{columns[i]}` = @value{i}, ";
				cls = cls.Substring(0, cls.Length - 2);
				string str = table_number == 1 ? "Места прибытия и отбытия" : "День прилета и отлета";
				string cmd = $"UPDATE `{str}` SET {cls} WHERE `Код` = {this.code}";
				OleDbCommand command = new OleDbCommand(cmd, connection);

				for (int i = 0; i < this.columns.Count; i++)
					command.Parameters.Add($"@value{i}", OleDbType.VarChar).Value = this.textboxes[i].Text;
				connection.Open();
				try
				{
					if (command.ExecuteNonQuery() == 1) MessageBox.Show("Запись отредактирована", "Успех");
					else MessageBox.Show("Запись не отредактирована", "Неудача");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				connection.Close();
			}
			CallBack.callbackEventHandler(true);
			this.Close();
		}
	}
}
