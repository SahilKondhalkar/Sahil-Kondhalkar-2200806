using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Xml.Linq;
using Microsoft.Identity.Client;

namespace Sahil_Kondhalkar_2200806
{
    public partial class Customertetxbox : Form
    {
        public Customertetxbox()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\91965\\Desktop\\Database FashionHub\\Sahil Kondhalkar 2200806\\Sahil Kondhalkar 2200806\\Customer.accdb\"";
            string query = "SELECT * FROM Customer";
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

       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }


    }
}
