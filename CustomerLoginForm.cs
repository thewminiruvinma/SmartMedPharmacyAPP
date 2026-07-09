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
    public partial class CustomerLoginForm : Form
    {
        public CustomerLoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            CustomerRegisterForm register = new CustomerRegisterForm();
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            try
            {
                MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString);

                    con.Open();

                string query = "SELECT * FROM Customer WHERE Username=@username AND Password=@password";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Session.CustomerID = Convert.ToInt32(reader["customerID"]);

                    CustomerDashboard dashboard = new CustomerDashboard();
                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

            con.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

private void CustomerLoginForm_Load(object sender, EventArgs e)
        {
            SetPlaceholder(txtUsername, "Username");
            SetPlaceholder(txtPassword, "Password");
        }

        private void SetPlaceholder(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;

            txt.Enter += RemovePlaceholder;
            txt.Leave += AddPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.ForeColor == Color.Gray)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;

                if (txt == txtPassword)
                    txt.UseSystemPasswordChar = true;
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (txt == txtUsername)
                    txt.Text = "Username";
                else if (txt == txtPassword)
                    txt.Text = "Password";

                txt.ForeColor = Color.Gray;

                if (txt == txtPassword)
                    txt.UseSystemPasswordChar = false;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
