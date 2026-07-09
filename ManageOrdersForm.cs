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
    public partial class ManageOrdersForm : Form
    {
        private string searchPlaceholder = "Search Order ID...";
        private string statusPlaceholder = "Select Status...";

        private int selectedOrderID = 0;
        public ManageOrdersForm()
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

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ManageCustomers customers = new ManageCustomers();
            customers.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.Show();
            this.Hide();
        }

        private void ManageOrdersForm_Load(object sender, EventArgs e)
        {
            // Search Placeholder
            txtSearch.Text = searchPlaceholder;
            txtSearch.ForeColor = Color.Gray;

            // Status Placeholder
            cmbStatus.Text = statusPlaceholder;
            cmbStatus.ForeColor = Color.Gray;

            cmbStatus.Items.Add("Processing");
            cmbStatus.Items.Add("In Delivery");
            cmbStatus.Items.Add("Delivered");
            cmbStatus.Items.Add("Cancelled");

            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    string query =
                    @"SELECT
                o.OrderID,
                c.FullName,
                o.OrderDate,
                o.TotalAmount,
                o.Status
              FROM Orders o
              INNER JOIN Customer c
              ON o.CustomerID = c.CustomerID";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvOrders.DataSource = dt;

                    dgvOrders.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;

                    dgvOrders.ReadOnly = true;

                    dgvOrders.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Set the color of the Status column based on its value
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.Cells["Status"].Value == null)
                    continue;

                string status =
                    row.Cells["Status"].Value.ToString();

                if (status == "Processing")
                    row.Cells["Status"].Style.ForeColor = Color.Goldenrod;

                else if (status == "In Delivery")
                    row.Cells["Status"].Style.ForeColor = Color.DodgerBlue;

                else if (status == "Delivered")
                    row.Cells["Status"].Style.ForeColor = Color.Green;

                else if (status == "Cancelled")
                    row.Cells["Status"].Style.ForeColor = Color.Red;

                row.Cells["Status"].Style.Font =
                    new Font("Segoe UI", 10, FontStyle.Bold);
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvOrders.Rows[e.RowIndex];

                selectedOrderID =
                    Convert.ToInt32(row.Cells["OrderID"].Value);

                cmbStatus.Text =
                    row.Cells["Status"].Value.ToString();
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (selectedOrderID == 0)
            {
                MessageBox.Show("Please select an order.");

                return;
            }

            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    string query =
                    @"UPDATE Orders
              SET Status=@Status
              WHERE OrderID=@OrderID";

                    MySqlCommand cmd =
                        new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        cmbStatus.Text);

                    cmd.Parameters.AddWithValue(
                        "@OrderID",
                        selectedOrderID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Order status updated successfully!");

                    LoadOrders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Prevent filtering if the text is just the placeholder string
            if (txtSearch.Text == searchPlaceholder)
            {
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    string query = @"SELECT
                                o.OrderID,
                                c.FullName,
                                o.OrderDate,
                                o.TotalAmount,
                                o.Status
                             FROM Orders o
                             INNER JOIN Customer c ON o.CustomerID = c.CustomerID
                             WHERE CAST(o.OrderID AS CHAR) LIKE @search";

                    // If a specific status filter is active, retain it during search
                    if (cmbStatus.SelectedIndex != -1 && cmbStatus.Text != statusPlaceholder)
                    {
                        query += " AND o.Status = @Status";
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                    if (query.Contains("@Status"))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOrders.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void cmbStatus_Enter(object sender, EventArgs e)
        {
            if (cmbStatus.Text == statusPlaceholder)
            {
                cmbStatus.Text = "";
                cmbStatus.ForeColor = Color.Black;
            }
        }

        private void cmbStatus_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                cmbStatus.Text = statusPlaceholder;
                cmbStatus.ForeColor = Color.Gray;
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ignore filtering if the user hasn't selected a real status or if it's the placeholder
            if (cmbStatus.SelectedIndex == -1 || cmbStatus.Text == statusPlaceholder)
            {
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    string query = @"SELECT
                                o.OrderID,
                                c.FullName,
                                o.OrderDate,
                                o.TotalAmount,
                                o.Status
                             FROM Orders o
                             INNER JOIN Customer c ON o.CustomerID = c.CustomerID
                             WHERE o.Status = @Status";

                    // If a search term is also present, combine the filters
                    if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text != searchPlaceholder)
                    {
                        query += " AND CAST(o.OrderID AS CHAR) LIKE @search";
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@Status", cmbStatus.Text);

                    if (query.Contains("@search"))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOrders.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
