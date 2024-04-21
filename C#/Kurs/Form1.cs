using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Kurs1
{
    public partial class Form1 : Form
    {
        public string filename = "";
        public static string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        public OleDbConnection connection = new OleDbConnection(con);
        public Form1()
        {
            InitializeComponent();
            CallBack.callbackEventHandler = new CallBack.callbackEvent(this.open_db);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            open_db();
        }

        public void open_db(bool closed = true)
        {
            if (closed)
            {
                if (this.filename.Length == 0)
                {
                    MessageBox.Show("Не открыт файл базы данных", "Неудача");
                    return;
                }
                connection = new OleDbConnection(con + filename);
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM `Места прибытия и отбытия`", connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                connection.Open();
                adapter.Fill(ds);
                table1.DataSource = ds.Tables[0];
                cmd = new OleDbCommand("SELECT * FROM `День прилета и отлета`", connection);
                adapter = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                table2.DataSource = ds.Tables[0];
                connection.Close();

                List<string> days = new List<string> { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
                foreach (string day in days) this.comboBox1.Items.Add(day);
                comboBox1.SelectedIndex = 0;

                List<string> destinations = new List<string>();
                foreach (DataGridViewRow row in table1.Rows) destinations.Add(row.Cells[3].Value.ToString());
                destinations = destinations.Distinct().ToList();
                foreach (string destination in destinations) comboBox2.Items.Add(destination);
                if (comboBox2.Items.Count > 0) comboBox2.SelectedIndex = 0;
            }
        }
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_db();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState.ToString() == "Minimized") return;
        }

        private void add1_Click(object sender, EventArgs e)
        {
            if (filename.Length == 0)
            {
                MessageBox.Show("Файл не открыт", "Неудача");
                return;
            }
            InputForm f1 = new InputForm(filename, this.table1, 1, 1);
            f1.Show();
        }
        private void add2_Click(object sender, EventArgs e)
        {
            if (filename.Length == 0)
            {
                MessageBox.Show("Файл не открыт", "Неудача");
                return;
            }
            InputForm f1 = new InputForm(filename, this.table2, 1, 2);
            f1.Show();
        }
        private void edit1_Click(object sender, EventArgs e)
        {
            if (filename.Length == 0)
            {
                MessageBox.Show("Файл не открыт", "Неудача");
                return;
            }
            if (this.table1.SelectedRows.Count == 0) return;
            InputForm f1 = new InputForm(filename, this.table1, 2, 1, int.Parse(this.table1.SelectedRows[0].Cells[0].Value.ToString()));
            f1.Show();
        }
        private void edit2_Click(object sender, EventArgs e)
        {
            if (filename.Length == 0)
            {
                MessageBox.Show("Файл не открыт", "Неудача");
                return;
            }
            if (this.table2.SelectedRows.Count == 0) return;
            InputForm f1 = new InputForm(filename, this.table2, 2, 2, int.Parse(this.table2.SelectedRows[0].Cells[0].Value.ToString()));
            f1.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            if (filename.Length == 0)
            {
                MessageBox.Show("Файл не открыт", "Неудача");
                return;
            }
            if (this.table1.SelectedRows.Count == 0) return;
            OleDbCommand command = new OleDbCommand("DELETE FROM `Места прибытия и отбытия` WHERE `Код` = @Code", connection);
            command.Parameters.Add("@Code", OleDbType.Integer).Value = table1[0, table1.SelectedRows[0].Index].Value.ToString();
            connection.Open();
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Запись удалена");
            else
                MessageBox.Show("Запись не удалена");
            open_db();
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            if (filename.Length == 0)
            {
                MessageBox.Show("Файл не открыт", "Неудача");
                return;
            }
            if (this.table2.SelectedRows.Count == 0) return;
            OleDbCommand command = new OleDbCommand("DELETE FROM `День прилета и отлета` WHERE `Код` = @Code", connection);
            command.Parameters.Add("@Code", OleDbType.Integer).Value = table2[0, table2.SelectedRows[0].Index].Value.ToString();
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Запись удалена");
            else
                MessageBox.Show("Запись не удалена");
            open_db();
        }

        public void clear_tables()
        {
            foreach (DataGridViewRow row in this.table1.Rows)
                row.DefaultCellStyle.BackColor = Color.White;
            foreach (DataGridViewRow row in this.table2.Rows)
                row.DefaultCellStyle.BackColor = Color.White;
        }

        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutForm()).Show();
        }

        private void search1_Click(object sender, EventArgs e)
        {
            clear_tables();
            if (filename.Length == 0)
            {
                MessageBox.Show("Файл не открыт", "Неудача");
                return;
            }
            string str = $"SELECT * FROM `День прилета и отлета` WHERE `День вылета` = '{comboBox1.Text}'";
            (new SearchResultsForm(filename, str)).Show();
        }

        private void search2_Click(object sender, EventArgs e)
        {
            if (filename.Length == 0)
            {
                MessageBox.Show("Файл не открыт", "Неудача");
                return;
            }
            string str = $"SELECT * FROM `Места прибытия и отбытия` WHERE `Пункт назначения` = '{comboBox2.Text}'";
            (new SearchResultsForm(filename, str)).Show();
        }

        private void search3_Click(object sender, EventArgs e)
        {
            if (filename.Length == 0)
            {
                MessageBox.Show("Файл не открыт", "Неудача");
                return;
            }
            string str = $"SELECT * FROM `День прилета и отлета` WHERE `День вылета` <> `День прилета`";
            (new SearchResultsForm(filename, str)).Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filterField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void пунктыОтправленияИНазначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Filtration(filename, table1, 1).Show();
        }

        private void дниВылетаИПрилетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Filtration(filename, table2, 2).Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void table2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    public static class CallBack
    {
        public delegate void callbackEvent(bool done);
        public static callbackEvent callbackEventHandler;
    }
}
