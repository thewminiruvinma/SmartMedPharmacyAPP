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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
            this.Hide();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm();
            cart.Show();
            this.Hide();
        }

        private void ordersbtn_Click(object sender, EventArgs e)
        {
            CustomerOrdersForm customerOrders = new CustomerOrdersForm();
            customerOrders.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeform = new WelcomeForm();
            welcomeform.Show();
            this.Hide();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                @"SELECT FullName,
                 Email,
                 Phone,
                 Address
          FROM Customer
          WHERE CustomerID=@CustomerID";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerID", Session.CustomerID);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtFullName.Text = reader["FullName"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == ""
                || txtEmail.Text == ""
                || txtPhone.Text == ""
                || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill all fields.");

                return;
            }

            using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                @"UPDATE Customer
                          SET

                          FullName=@FullName,

                          Email=@Email,

                          Phone=@Phone,

                          Address=@Address

                          WHERE CustomerID=@CustomerID";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);

                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);

                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                cmd.Parameters.AddWithValue("@CustomerID", Session.CustomerID);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Profile Updated Successfully!");
            }
        }
    }
}
