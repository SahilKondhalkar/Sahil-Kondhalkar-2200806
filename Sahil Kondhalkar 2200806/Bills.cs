using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahil_Kondhalkar_2200806
{
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\91965\\source\\repos\\Sahil Kondhalkar 2200806\\Sahil Kondhalkar 2200806\\Bills.accdb\"";
            string query = "SELECT * FROM Bills";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }

        }
    }
}
