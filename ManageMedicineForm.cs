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
            LoadMedicines();
            LoadCategories();
            ResetPlaceholders();
        }

        // Reset all placeholders to their default values
        private void ResetPlaceholders()
        {
            SetPlaceholder(txtSearch, searchPlaceholder);
            SetPlaceholder(txtMedicineName, medicinePlaceholder);
            SetPlaceholder(cmbCategory, categoryPlaceholder);
            SetPlaceholder(txtPrice, pricePlaceholder);
            SetPlaceholder(txtStock, stockPlaceholder);
            SetPlaceholder(txtSupplier, supplierPlaceholder);
        }

        // Set placeholder text and color for a control
        private void SetPlaceholder(Control control, string placeholder)
        {
            control.Text = placeholder;
            control.ForeColor = Color.Gray;
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
            if (!ValidateInputs(out decimal price, out int stock)) return;

            try
            {
                using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();
                    string query = @"INSERT INTO Medicine 
                                    (Name, Category, Price, StockQuantity, Supplier, ExpiryDate) 
                                    VALUES 
                                    (@Name, @Category, @Price, @Stock, @Supplier, @ExpiryDate)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtMedicineName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text == supplierPlaceholder ? "" : txtSupplier.Text.Trim());
                        cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value.Date);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Medicine Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMedicines();
                LoadCategories();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding medicine: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear input fields after adding or updating a medicine
        private void ClearFields()
        {
            selectedMedicineID = 0;
            dtpExpiryDate.Value = DateTime.Now;
            ResetPlaceholders();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMedicineID == 0)
            {
                MessageBox.Show("Please select a medicine from the list to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this medicine record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM Medicine WHERE MedicineID=@MedicineID";

                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@MedicineID", selectedMedicineID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Medicine Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadMedicines();
                                LoadCategories();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Delete failed. Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting medicine: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchVal = txtSearch.Text.Trim();
            if (searchVal == searchPlaceholder) searchVal = "";

            try
            {
                using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Medicine WHERE Name LIKE @search OR Category LIKE @search";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchVal + "%");
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMedicine.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedMedicineID == 0)
            {
                MessageBox.Show("Please select a medicine from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs(out decimal price, out int stock)) return;

            try
            {
                using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();
                    string query = @"UPDATE Medicine SET 
                                    Name=@Name, 
                                    Category=@Category, 
                                    Price=@Price, 
                                    StockQuantity=@Stock, 
                                    Supplier=@Supplier, 
                                    ExpiryDate=@ExpiryDate 
                                    WHERE MedicineID=@MedicineID";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtMedicineName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text == supplierPlaceholder ? "" : txtSupplier.Text.Trim());
                        cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value.Date);
                        cmd.Parameters.AddWithValue("@MedicineID", selectedMedicineID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Medicine Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMedicines();
                            LoadCategories();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating medicine: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
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

        // Handle cell click event to populate input fields with selected medicine details
        private void dgvMedicine_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMedicine.Rows.Count)
            {
                DataGridViewRow row = dgvMedicine.Rows[e.RowIndex];

                if (row.Cells["MedicineID"].Value != DBNull.Value)
                {
                    selectedMedicineID = Convert.ToInt32(row.Cells["MedicineID"].Value);

                    txtMedicineName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                    txtMedicineName.ForeColor = Color.Black;

                    cmbCategory.Text = row.Cells["Category"].Value?.ToString() ?? "";
                    cmbCategory.ForeColor = Color.Black;

                    txtPrice.Text = row.Cells["Price"].Value?.ToString() ?? "";
                    txtPrice.ForeColor = Color.Black;

                    txtStock.Text = row.Cells["StockQuantity"].Value?.ToString() ?? "";
                    txtStock.ForeColor = Color.Black;

                    txtSupplier.Text = row.Cells["Supplier"].Value?.ToString() ?? "";
                    txtSupplier.ForeColor = Color.Black;

                    if (row.Cells["ExpiryDate"].Value != DBNull.Value)
                    {
                        dtpExpiryDate.Value = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);
                    }
                }
            }
        }

        // Validate user inputs before adding or updating a medicine
        private bool ValidateInputs(out decimal price, out int stock)
        {
            price = 0;
            stock = 0;

            // 1. Medicine Name Validation
            if (string.IsNullOrWhiteSpace(txtMedicineName.Text) || txtMedicineName.Text == medicinePlaceholder)
            {
                MessageBox.Show("Please enter a valid medicine name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedicineName.Focus();
                return false;
            }

            // 2. Category Validation
            if (string.IsNullOrWhiteSpace(cmbCategory.Text) || cmbCategory.Text == categoryPlaceholder)
            {
                MessageBox.Show("Please select or enter a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            // 3. Price Validation (Must be a valid positive number)
            if (!decimal.TryParse(txtPrice.Text.Trim(), out price) || price < 0)
            {
                MessageBox.Show("Price cannot be negative or empty. Please enter a valid non-negative price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            // 4. Stock Quantity Validation (Must be a valid non-negative integer)
            if (!int.TryParse(txtStock.Text.Trim(), out stock) || stock < 0)
            {
                MessageBox.Show("Stock quantity cannot be negative. Please enter a valid zero or positive quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            return true;
        }

    }
    
}
