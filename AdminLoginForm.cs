using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMedPharmacyAPP
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    string query = @"SELECT * FROM Admin WHERE Username=@Username AND Password=@Password";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            Session.AdminID = Convert.ToInt32(reader["AdminID"]);
                            Session.AdminUsername = reader["Username"].ToString();

                            MessageBox.Show("Login Successful!");

                            AdminDashboard dashboard = new AdminDashboard();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password.");
                        }
                    } 
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    } 
} 
