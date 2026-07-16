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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
            LoadExpiryAlerts();
            LoadLowStockAlert();
        }

        // Load dashboard data
        private void LoadDashboard()
        {
            try
            {
                LoadTotalSales();
                LoadMedicineStock();
                LoadActiveOrders();
                LoadTotalCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Load total sales from the database
        private void LoadTotalSales()
        {
            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                @"SELECT IFNULL(SUM(TotalAmount),0)
          FROM Orders
          WHERE Status='Delivered'";

                MySqlCommand cmd = new MySqlCommand(query, con);

                decimal total =
                    Convert.ToDecimal(cmd.ExecuteScalar());

                lblTotalSales.Text =
                    "Rs. " + total.ToString("N2");
            }
        }

        // Load medicine stock from the database
        private void LoadMedicineStock()
        {
            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                @"SELECT IFNULL(SUM(StockQuantity),0)
          FROM Medicine";

                MySqlCommand cmd = new MySqlCommand(query, con);

                int stock =
                    Convert.ToInt32(cmd.ExecuteScalar());

                lblMedicineStock.Text =
                    stock.ToString();
            }
        }

        // Load active orders from the database
        private void LoadActiveOrders()
        {
            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                @"SELECT COUNT(*)
          FROM Orders
          WHERE Status='Processing'
          OR Status='In Delivery'";

                MySqlCommand cmd = new MySqlCommand(query, con);

                int orders =
                    Convert.ToInt32(cmd.ExecuteScalar());

                lblActiveOrders.Text =
                    orders.ToString();
            }
        }

        // Load total customers from the database
        private void LoadTotalCustomers()
        {
            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                @"SELECT COUNT(*)
          FROM Customer";

                MySqlCommand cmd = new MySqlCommand(query, con);

                int customers =
                    Convert.ToInt32(cmd.ExecuteScalar());

                lblTotalCustomers.Text =
                    customers.ToString();
            }
        }

        // Load expiry alerts from the database
        private void LoadExpiryAlerts()
        {
            lstExpiryMedicines.Items.Clear();

            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query = @"
        SELECT
            Name,
            ExpiryDate
        FROM Medicine
        WHERE ExpiryDate BETWEEN CURDATE()
        AND DATE_ADD(CURDATE(), INTERVAL 30 DAY)
        ORDER BY ExpiryDate";

                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    string medicine = reader["Name"].ToString();

                    DateTime expiry =
                        Convert.ToDateTime(reader["ExpiryDate"]);

                    int days =
                        (expiry - DateTime.Today).Days;

                    if (days <= 7)
                    {
                        lstExpiryMedicines.Items.Add(
                            "🚨 " + medicine + " (" + days + " days)");
                    }
                    else
                    {
                        lstExpiryMedicines.Items.Add(
                            "⚠ " + medicine + " (" + days + " days)");
                    }

                    count++;
                }

                lblExpiryCount.Text = "Total : " + count;
            }
        }

        // Load low stock alerts from the database
        private void LoadLowStockAlert()
        {
            lstLowStock.Items.Clear();

            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query = @"
                    SELECT Name, StockQuantity
                    FROM Medicine
                    WHERE StockQuantity < 10
                    ORDER BY StockQuantity ASC";

                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    string medicine = reader["Name"].ToString();
                    int stock = Convert.ToInt32(reader["StockQuantity"]);

                    if (stock <= 5)
                    {
                        lstLowStock.Items.Add(
                            "🚨 " + medicine + " (Stock: " + stock + ")");
                    }
                    else
                    {
                        lstLowStock.Items.Add(
                            "⚠ " + medicine + " (Stock: " + stock + ")");
                    }

                    count++;
                }

                reader.Close();

                lblLowStockCount.Text = "Total : " + count;

                // Change panel colour
                if (count > 0)
                {
                    panelLowStock.BackColor = Color.MistyRose;
                }
                else
                {
                    panelLowStock.BackColor = Color.Honeydew;
                }
            }
        }

        private void lblTotalCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
