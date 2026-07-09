using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartMedPharmacyAPP
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            CustomerLoginForm customerlogin = new CustomerLoginForm();
            customerlogin.Show();
            this.Hide();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            AdminLoginForm admin = new AdminLoginForm();
            admin.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                try
                {
                    using (MySqlConnection con =
                        new MySqlConnection(DBConnection.ConnectionString))
                    {
                        con.Open();
                        MessageBox.Show("Database Connected Successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        
        }
    }
}
