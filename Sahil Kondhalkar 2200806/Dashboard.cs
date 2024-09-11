using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Sahil_Kondhalkar_2200806
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Purchase purchase = new Purchase();
           purchase.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customertetxbox customer = new Customertetxbox();
            customer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }
    }
}
