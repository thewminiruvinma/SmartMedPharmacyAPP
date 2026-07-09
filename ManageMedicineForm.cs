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
    public partial class ManageMedicineForm : Form

    {
        private string searchPlaceholder = "Search medicine...";
        private string medicinePlaceholder = "Medicine Name";
        private string categoryPlaceholder = "Select Category...";
        private string pricePlaceholder = "Price";
        private string stockPlaceholder = "Stock Quantity";
        private string supplierPlaceholder = "Supplier";

        private int selectedMedicineID = 0;

        public ManageMedicineForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AdminLoginForm login = new AdminLoginForm();
            login.Show();
            this.Hide();
        }

        private void dgvMedicine_CellClick(object sender,
 DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvMedicine.Rows[e.RowIndex];

                selectedMedicineID =
                    Convert.ToInt32(row.Cells["MedicineID"].Value);

                txtMedicineName.Text =
                    row.Cells["Name"].Value.ToString();

                cmbCategory.Text =
                    row.Cells["Category"].Value.ToString();

                txtPrice.Text =
                    row.Cells["Price"].Value.ToString();

                txtStock.Text =
                    row.Cells["StockQuantity"].Value.ToString();

                txtSupplier.Text =
                    row.Cells["Supplier"].Value.ToString();

                dtpExpiryDate.Value =
                    Convert.ToDateTime(row.Cells["ExpiryDate"].Value);
            }
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageMedicineForm_Load(object sender, EventArgs e)
        {
            // Search
            txtSearch.Text = searchPlaceholder;
            txtSearch.ForeColor = Color.Gray;

            // Medicine Name
            txtMedicineName.Text = medicinePlaceholder;
            txtMedicineName.ForeColor = Color.Gray;

            // Category
            cmbCategory.Text = categoryPlaceholder;
            cmbCategory.ForeColor = Color.Gray;

            // Price
            txtPrice.Text = pricePlaceholder;
            txtPrice.ForeColor = Color.Gray;

            // Stock
            txtStock.Text = stockPlaceholder;
            txtStock.ForeColor = Color.Gray;

            // Supplier
            txtSupplier.Text = supplierPlaceholder;
            txtSupplier.ForeColor = Color.Gray;

            LoadMedicines();
            LoadCategories();
        }

        // Load medicines from the database and display them in the DataGridView
        private void LoadMedicines()
        {
            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    string query = "SELECT * FROM Medicine";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvMedicine.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCategories()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    string query = "SELECT DISTINCT Category FROM Medicine ORDER BY Category";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbCategory.Items.Clear();

                    while (reader.Read())
                    {
                        cmbCategory.Items.Add(reader["Category"].ToString());
                    }

                    reader.Close();
                }

                // Show placeholder
                cmbCategory.Text = categoryPlaceholder;
                cmbCategory.ForeColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    string query =
                    @"INSERT INTO Medicine
            (Name,Category,Price,StockQuantity,Supplier,ExpiryDate)

            VALUES

            (@Name,@Category,@Price,@Stock,@Supplier,@ExpiryDate)";
                    MySqlCommand cmd =
    new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Name",
                        txtMedicineName.Text);

                    cmd.Parameters.AddWithValue("@Category",
                        cmbCategory.Text);

                    cmd.Parameters.AddWithValue("@Price",
                        txtPrice.Text);

                    cmd.Parameters.AddWithValue("@Stock",
                        txtStock.Text);

                    cmd.Parameters.AddWithValue("@Supplier",
                        txtSupplier.Text);

                    cmd.Parameters.AddWithValue("@ExpiryDate",
                        dtpExpiryDate.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Medicine Added!");

                    LoadMedicines();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Clear input fields after adding or updating a medicine
        private void ClearFields()
        {
            txtMedicineName.Clear();

            cmbCategory.SelectedIndex = -1;

            txtPrice.Clear();

            txtStock.Clear();

            txtSupplier.Clear();

            dtpExpiryDate.Value = DateTime.Now;

            selectedMedicineID = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMedicineID == 0)
            {
                MessageBox.Show("Select a medicine.");

                return;
            }

            if (MessageBox.Show("Delete this medicine?",
                "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection con =
                    new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    string query =
                    "DELETE FROM Medicine WHERE MedicineID=@MedicineID";

                    MySqlCommand cmd =
                        new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@MedicineID",
                        selectedMedicineID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deleted!");

                    LoadMedicines();

                    ClearFields();
                }
            }
        }


        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                @"SELECT *

        FROM Medicine

        WHERE Name LIKE @search";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearch.Text + "%");

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvMedicine.DataSource = dt;
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedMedicineID == 0)
            {
                MessageBox.Show("Select a medicine.");

                return;
            }

            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                @"UPDATE Medicine

        SET

        Name=@Name,

        Category=@Category,

        Price=@Price,

        StockQuantity=@Stock,

        Supplier=@Supplier,

        ExpiryDate=@ExpiryDate

        WHERE MedicineID=@MedicineID";

                MySqlCommand cmd =
                    new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name",
                    txtMedicineName.Text);

                cmd.Parameters.AddWithValue("@Category",
                    cmbCategory.Text);

                cmd.Parameters.AddWithValue("@Price",
                    txtPrice.Text);

                cmd.Parameters.AddWithValue("@Stock",
                    txtStock.Text);

                cmd.Parameters.AddWithValue("@Supplier",
                    txtSupplier.Text);

                cmd.Parameters.AddWithValue("@ExpiryDate",
                    dtpExpiryDate.Value);

                cmd.Parameters.AddWithValue("@MedicineID",
                    selectedMedicineID);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Updated!");

                LoadMedicines();

                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void dtpExpiryDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

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

        private void txtMedicineName_Enter(object sender, EventArgs e)
        {
            if (txtMedicineName.Text == medicinePlaceholder)
            {
                txtMedicineName.Text = "";
                txtMedicineName.ForeColor = Color.Black;
            }
        }

        private void txtMedicineName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicineName.Text))
            {
                txtMedicineName.Text = medicinePlaceholder;
                txtMedicineName.ForeColor = Color.Gray;
            }
        }

        private void cmbCategory_Enter(object sender, EventArgs e)
        {
            if (cmbCategory.Text == categoryPlaceholder)
            {
                cmbCategory.Text = "";
                cmbCategory.ForeColor = Color.Black;
            }
        }

        private void cmbCategory_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                cmbCategory.Text = categoryPlaceholder;
                cmbCategory.ForeColor = Color.Gray;
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text == pricePlaceholder)
            {
                txtPrice.Text = "";
                txtPrice.ForeColor = Color.Black;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                txtPrice.Text = pricePlaceholder;
                txtPrice.ForeColor = Color.Gray;
            }
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplier_Enter(object sender, EventArgs e)
        {
            if (txtSupplier.Text == supplierPlaceholder)
            {
                txtSupplier.Text = "";
                txtSupplier.ForeColor = Color.Black;
            }
        }

        private void txtSupplier_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                txtSupplier.Text = supplierPlaceholder;
                txtSupplier.ForeColor = Color.Gray;
            }
        }

        private void txtStock_Enter(object sender, EventArgs e)
        {
            if (txtStock.Text == stockPlaceholder)
            {
                txtStock.Text = "";
                txtStock.ForeColor = Color.Black;
            }
        }

        private void txtStock_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                txtStock.Text = stockPlaceholder;
                txtStock.ForeColor = Color.Gray;
            }
        }
    }
    
}
