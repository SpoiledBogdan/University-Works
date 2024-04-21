using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace Kurs1
{
    public partial class Filtration : Form
    {
        public int table_number;
        public string filename = "";
        public static string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        public OleDbConnection connection = new OleDbConnection(con);
        public DataGridView table;
        public Filtration(string filename, DataGridView table, int table_number)
        {
            InitializeComponent();
            this.filename = filename;
            this.table = table;
            this.table_number = table_number;

            foreach (DataGridViewColumn column in this.table.Columns)
            {
                filterField1.Items.Add(column.Name);
            }
            if (filterField1.Items.Count > 0) filterField1.SelectedIndex = 0;
        }

        private void filter_Click(object sender, EventArgs e)
        {
            if (this.table_number == 1)
            {
                string str = $"SELECT * FROM `Места прибытия и отбытия` WHERE `{filterField1.Text}` LIKE '%{filterText.Text}%'";
                (new SearchResultsForm(filename, str)).Show();
            }

            if (this.table_number == 2)
            {
                string str = $"SELECT * FROM `День прилета и отлета` WHERE `{filterField1.Text}` LIKE '%{filterText.Text}%'";
                (new SearchResultsForm(filename, str)).Show();
            }
        }

        private void exportToJSON_Click(object sender, EventArgs e)
        {
            if (this.filename.Length == 0)
            {
                MessageBox.Show("Не открыт файл базы данных", "Неудача");
                return;
            }
            using (var writer = new StreamWriter("results.json"))
            {
                int number = 0;
                for (int i = 0; i < table.ColumnCount; i++)
                {
                    if (this.table.Columns[i].ToString() == filterField1.SelectedItem.ToString())
                        number = i;
                }
                writer.WriteLine($"{{\n\t\"field\" : \"{this.table.Columns[number].Name}\", \n\t\"filter_text\" : \"{filterText.Text}\",\n\t\"results\" : [");
                foreach (DataGridViewRow row in this.table.Rows)
                {
                    if (row.Cells[number].Value.ToString().Contains(this.filterText.Text) == true)
                    {
                        writer.WriteLine("\t\t{");
                        foreach (DataGridViewColumn q in this.table.Columns)
                        {
                            writer.WriteLine($"\t\t\t\"{q.Name}\" : \"{row.Cells[q.Index].Value.ToString()}\", ");
                        }
                        writer.WriteLine("\n\t\t}, ");
                    }
                }
                writer.WriteLine($"\n\t]\n}}");
            }
            MessageBox.Show("Запись успешно завершена", "Успешно");
        }
    }
}