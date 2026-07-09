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
    public partial class CustomerRegisterForm : Form
    {
        public CustomerRegisterForm()
        {
            InitializeComponent();
        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerRegisterForm_Load(object sender, EventArgs e)
        {
            SetPlaceholder(txtFullName, "Full Name");
            SetPlaceholder(txtEmail, "Email Address");
            SetPlaceholder(txtPhone, "Phone Number");
            SetPlaceholder(txtAddress, "Address");
            SetPlaceholder(txtUsername, "Username");
            SetPlaceholder(txtPassword, "Password");
            SetPlaceholder(txtConfirmPassword, "Confirm Password");
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

                if (txt == txtPassword || txt == txtConfirmPassword)
                {
                    txt.UseSystemPasswordChar = true;
                }
            }
        }
        private void AddPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (txt == txtFullName)
                    txt.Text = "Full Name";
                else if (txt == txtEmail)
                    txt.Text = "Email Address";
                else if (txt == txtPhone)
                    txt.Text = "Phone Number";
                else if (txt == txtAddress)
                    txt.Text = "Address";
                else if (txt == txtUsername)
                    txt.Text = "Username";
                else if (txt == txtPassword)
                    txt.Text = "Password";
                else if (txt == txtConfirmPassword)
                    txt.Text = "Confirm Password";

                txt.ForeColor = Color.Gray;

                if (txt == txtPassword || txt == txtConfirmPassword)
                {
                    txt.UseSystemPasswordChar = false;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CustomerLoginForm customerlogin = new CustomerLoginForm();
            customerlogin.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            {
                //Check empty fields
                if (txtFullName.Text == "" ||
                    txtEmail.Text == "" ||
                    txtPhone.Text == "" ||
                    txtAddress.Text == "" ||
                    txtUsername.Text == "" ||
                    txtPassword.Text == "" ||
                    txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                //Check passwords
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                try
                {
                    using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
                    {
                        con.Open();

                        string check = "SELECT COUNT(*) FROM customer WHERE Username=@Username OR Email=@Email";

                        MySqlCommand checkCmd = new MySqlCommand(check, con);

                        checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Username or Email already exists.");
                            return;
                        }

                        string query = @"INSERT INTO customer
                            (FullName, Email, Phone, Address, Username, Password)
                            VALUES
                            (@FullName,@Email,@Phone,@Address,@Username,@Password)";

                        MySqlCommand cmd = new MySqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration Successful!");

                        txtFullName.Clear();
                        txtEmail.Clear();
                        txtPhone.Clear();
                        txtAddress.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtConfirmPassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
     }
}

