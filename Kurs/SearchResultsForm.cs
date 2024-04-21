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
namespace Kurs1
{
    public partial class SearchResultsForm : Form
    {
        public static string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        public OleDbConnection connection = new OleDbConnection(con);
        public SearchResultsForm(string filename, string command)
        {
            InitializeComponent();
            connection = new OleDbConnection(con + filename);
            OleDbCommand cmd = new OleDbCommand(command, connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            connection.Open();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
