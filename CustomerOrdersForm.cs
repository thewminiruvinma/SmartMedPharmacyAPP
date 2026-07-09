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
    public partial class CustomerOrdersForm : Form
    {
        private string searchPlaceholder = "Search Order ID...";
        private string categoryPlaceholder = "Select Status...";

        public CustomerOrdersForm()
        {
            InitializeComponent();
        }

        private void Searchpanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm();
            profile.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeform = new WelcomeForm();
            welcomeform.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerOrdersForm_Load(object sender, EventArgs e)
        {
            // Search Box Placeholder
            txtSearch.Text = searchPlaceholder;
            txtSearch.ForeColor = Color.Gray;

            // Status ComboBox Placeholder
            cmbStatus.Text = categoryPlaceholder;
            cmbStatus.ForeColor = Color.Gray;

            LoadOrders();
        }

        private void LoadOrders(string search = "", string status = "")
        {
            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query = @"
        SELECT OrderID, OrderDate, TotalAmount, Status
        FROM Orders
        WHERE CustomerID=@CustomerID
        AND CAST(OrderID AS CHAR) LIKE @search";

                // If a status is selected, filter by status
                if (!string.IsNullOrEmpty(status))
                {
                    query += " AND Status=@status";
                }

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue("@CustomerID", Session.CustomerID);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");

                if (!string.IsNullOrEmpty(status))
                {
                    da.SelectCommand.Parameters.AddWithValue("@status", status);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrders.DataSource = dt;
            }

            // Status colors
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.Cells["Status"].Value == null)
                    continue;

                string orderStatus = row.Cells["Status"].Value.ToString();

                switch (orderStatus)
                {
                    case "Processing":
                        row.Cells["Status"].Style.ForeColor = Color.Goldenrod;
                        break;

                    case "In Delivery":
                        row.Cells["Status"].Style.ForeColor = Color.DodgerBlue;
                        break;

                    case "Delivered":
                        row.Cells["Status"].Style.ForeColor = Color.Green;
                        break;

                    case "Cancelled":
                        row.Cells["Status"].Style.ForeColor = Color.Red;
                        break;
                }

                row.Cells["Status"].Style.Font =
                    new Font("Segoe UI", 10, FontStyle.Bold);
            }
        }

        private void txtSearchOrder_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Order ID...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearchOrder_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search Order ID...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearchOrder_TextChanged(object sender, EventArgs e)
        {
            string status = cmbStatus.ForeColor == Color.Gray
                            ? ""
                            : cmbStatus.Text;

            LoadOrders(txtSearch.Text, status);
        }

        private void cmbStatus_Enter(object sender, EventArgs e)
        {
            if (cmbStatus.Text == categoryPlaceholder)
            {
                cmbStatus.Text = "";
                cmbStatus.ForeColor = Color.Black;
            }
        }

        private void cmbStatus_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                cmbStatus.Text = categoryPlaceholder;
                cmbStatus.ForeColor = Color.Gray;
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.ForeColor == Color.Gray)
                return;

            LoadOrders(txtSearch.Text, cmbStatus.Text);
        }
    }
}
