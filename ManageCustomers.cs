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
    public partial class ManageCustomers : Form
    {
        private string fullNamePlaceholder = "Full Name";
        private string phonePlaceholder = "Phone Number";
        private string emailPlaceholder = "Email Address";
        private string addressPlaceholder = "Address";
        private string searchPlaceholder = "Search customer...";
        private int selectedCustomerID = 0;
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            ManageMedicineForm medicine = new ManageMedicineForm();
            medicine.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ManageOrdersForm orders = new ManageOrdersForm();
            orders.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AdminLoginForm admin = new AdminLoginForm();
            admin.Show();
            this.Hide();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvCustomers.Rows[e.RowIndex];

                selectedCustomerID =
                    Convert.ToInt32(row.Cells["CustomerID"].Value);

                txtFullName.Text =
                    row.Cells["FullName"].Value.ToString();

                txtEmail.Text =
                    row.Cells["Email"].Value.ToString();

                txtPhone.Text =
                    row.Cells["Phone"].Value.ToString();

                txtAddress.Text =
                    row.Cells["Address"].Value.ToString();
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            // Full Name
            txtFullName.Text = fullNamePlaceholder;
            txtFullName.ForeColor = Color.Gray;

            // Phone
            txtPhone.Text = phonePlaceholder;
            txtPhone.ForeColor = Color.Gray;

            // Email
            txtEmail.Text = emailPlaceholder;
            txtEmail.ForeColor = Color.Gray;

            // Address
            txtAddress.Text = addressPlaceholder;
            txtAddress.ForeColor = Color.Gray;


            txtSearch.Text = searchPlaceholder;
            txtSearch.ForeColor = Color.Gray;

            LoadCustomers();
        }


        private void LoadCustomers()
        {
            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    string query =
                    @"SELECT
                CustomerID,
                FullName,
                Email,
                Phone,
                Address,
                Username
              FROM Customer";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvCustomers.DataSource = dt;

                    dgvCustomers.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;

                    dgvCustomers.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dgvCustomers.ReadOnly = true;

                    dgvCustomers.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == 0)
            {
                MessageBox.Show("Please select a customer.");

                return;
            }

            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(DBConnection.ConnectionString))
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

                    MySqlCommand cmd =
                        new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer updated successfully!");

                    LoadCustomers();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ClearFields()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            selectedCustomerID = 0;

            dgvCustomers.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    string query =
                    @"SELECT
                CustomerID,
                FullName,
                Email,
                Phone,
                Address,
                Username
              FROM Customer
              WHERE FullName LIKE @search
                 OR Email LIKE @search
                 OR Username LIKE @search";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, con);

                    da.SelectCommand.Parameters.AddWithValue(
                        "@search",
                        "%" + txtSearch.Text + "%");

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvCustomers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == searchPlaceholder)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = searchPlaceholder;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == fullNamePlaceholder)
            {
                txtFullName.Text = "";
                txtFullName.ForeColor = Color.Black;
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                txtFullName.Text = fullNamePlaceholder;
                txtFullName.ForeColor = Color.Gray;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == phonePlaceholder)
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text = phonePlaceholder;
                txtPhone.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == emailPlaceholder)
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = emailPlaceholder;
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == addressPlaceholder)
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.Black;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                txtAddress.Text = addressPlaceholder;
                txtAddress.ForeColor = Color.Gray;
            }
        }
    }
}
