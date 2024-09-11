using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahil_Kondhalkar_2200806
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string username = textBox1.Text;
            //string password = textBox2.Text;

            //if (username == "Fashion" && password == "Fashion")
            //{
            //  MessageBox.Show("Login Successful!", "Success");

            //this.Hide();
            //Dashboard dashboard = new Dashboard();
            //dashboard.Show();
            //}
            //else
            //{
            //  MessageBox.Show("Invalid Username or Password", "Error");
            //}

           // this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
           
   

