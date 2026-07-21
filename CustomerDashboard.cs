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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeform = new WelcomeForm();
            welcomeform.Show();
            this.Hide();
        }

        private void Leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartForm cartform = new CartForm();
            cartform.Show();
            this.Hide();
        }

        private void ordersbtn_Click(object sender, EventArgs e)
        {
            CustomerOrdersForm customerorders = new CustomerOrdersForm();
            customerorders.Show();
            this.Hide();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm();
            profile.Show();
            this.Hide();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            // Unhook events temporarily so setting initial values doesn't trigger database calls
            txtSearch.TextChanged -= txtSearch_TextChanged;
            cmbCategory.SelectedIndexChanged -= cmbCategory_SelectedIndexChanged;

            LoadMedicines();
            LoadCategories();
            

            // setting the placeholder text for the search textbox
            txtSearch.Text = "Search for medicines";
            txtSearch.ForeColor = Color.Gray;


            // Hook the events back up now that layout values are set
            txtSearch.TextChanged += txtSearch_TextChanged;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
        }

        // creating the method to load the medicines from the database and display them in the flow layout panel
        private void LoadMedicines(string search = "", string category = "All Categories")
        {
            flpMedicines.Controls.Clear();

            string query = "SELECT * FROM medicine WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(search))
            {
                query += " AND Name LIKE @search";
            }

            if (category != "All Categories")
            {
                query += " AND Category=@category";
            }

            using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);

                if (!string.IsNullOrWhiteSpace(search))
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                if (category != "All Categories")
                    cmd.Parameters.AddWithValue("@category", category);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Pass the reader object directly instead of individual fields
                    Panel card = CreateMedicineCard(reader);

                    flpMedicines.Controls.Add(card);
                }
            }
        }

        // creating the method to load the categories from the database and add them to the combobox
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            // Default option
            cmbCategory.Items.Add("All Categories");

            using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query = "SELECT DISTINCT Category FROM Medicine ORDER BY Category";

                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbCategory.Items.Add(reader["Category"].ToString());
                }

                reader.Close();
            }

            cmbCategory.SelectedIndex = 0;
        }


        // creating the card for each medicine to display in the flow layout panel
        private Panel CreateMedicineCard(MySqlDataReader reader)
        {
            // Extract the MedicineID right away so the button click knows which item it belongs to
            int medicineID = Convert.ToInt32(reader["MedicineID"]);
            int stockQuantity = Convert.ToInt32(reader["StockQuantity"]);

            Panel card = new Panel();

            card.Width = 220;
            card.Height = 270;
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(15);


            // medicine name
            Label lblName = new Label();
            lblName.Text = reader["Name"].ToString();
            lblName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblName.Location = new Point(15, 20);
            lblName.AutoSize = true;
            card.Controls.Add(lblName);


            // medicine category
            Label lblCategory = new Label();
            lblCategory.Text = reader["Category"].ToString();
            lblCategory.Location = new Point(15, 60);
            lblCategory.AutoSize = true;
            card.Controls.Add(lblCategory);


            // medicine price
            Label lblPrice = new Label();
            lblPrice.Text = "Rs. " + reader["Price"].ToString();
            lblPrice.Location = new Point(15, 95);
            lblPrice.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            card.Controls.Add(lblPrice);


            // medicine stock
            Label lblStock = new Label();
            lblStock.Text = "Stock : " + reader["StockQuantity"].ToString();
            lblStock.Location = new Point(15, 130);
            card.Controls.Add(lblStock);


            // add to cart button
            Button btnAdd = new Button();
            btnAdd.Text = "Add To Cart";
            btnAdd.Width = 170;
            btnAdd.Height = 40;
            btnAdd.Location = new Point(20, 190);
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.ForeColor = Color.White;

            // Wire up the click event handler to execute your AddToCart method
            if (stockQuantity <= 0)
            {
                lblStock.Text = "Stock : Out of Stock";
                lblStock.ForeColor = Color.Red;
                lblStock.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                btnAdd.Text = "Out of Stock";
                btnAdd.BackColor = Color.Gray;
                btnAdd.ForeColor = Color.White;
                btnAdd.Enabled = false; // Disable button when out of stock
            }
            else
            {
                lblStock.Text = "Stock : " + stockQuantity;
                lblStock.ForeColor = Color.Black;

                btnAdd.Text = "Add To Cart";
                btnAdd.BackColor = Color.MidnightBlue;
                btnAdd.ForeColor = Color.White;
                btnAdd.Enabled = true;

                // Wire up the click event handler
                btnAdd.Click += (sender, e) =>
                {
                    AddToCart(medicineID);
                };
            }

            card.Controls.Add(lblStock);
            card.Controls.Add(btnAdd);

            return card;
        }

        private void AddToCart(int medicineID)
        {
            using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                // 1. Fetch current stock and price directly from the DB
                string medicineQuery = "SELECT Price, StockQuantity FROM Medicine WHERE MedicineID=@MedicineID";
                MySqlCommand medicineCmd = new MySqlCommand(medicineQuery, con);
                medicineCmd.Parameters.AddWithValue("@MedicineID", medicineID);

                decimal price = 0;
                int currentStock = 0;

                using (MySqlDataReader reader = medicineCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        price = Convert.ToDecimal(reader["Price"]);
                        currentStock = Convert.ToInt32(reader["StockQuantity"]);
                    }
                    else
                    {
                        MessageBox.Show("Medicine not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // 2. Check if medicine already exists in cart
                string checkQuery = @"SELECT Quantity
                                      FROM Cart
                                      WHERE CustomerID=@CustomerID
                                      AND MedicineID=@MedicineID";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@CustomerID", Session.CustomerID);
                checkCmd.Parameters.AddWithValue("@MedicineID", medicineID);

                object result = checkCmd.ExecuteScalar();

                if (result != null)
                {
                    int currentCartQty = Convert.ToInt32(result);

                    // Verify if adding 1 more exceeds available stock
                    if (currentCartQty + 1 > currentStock)
                    {
                        MessageBox.Show($"Cannot add more. Only {currentStock} unit(s) available in stock.",
                                        "Stock Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int quantity = currentCartQty + 1;
                    decimal subtotal = quantity * price;

                    string updateQuery = @"UPDATE Cart
                                           SET Quantity=@Quantity,
                                               Price=@Price,
                                               SubTotal=@SubTotal
                                           WHERE CustomerID=@CustomerID
                                           AND MedicineID=@MedicineID";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);

                    updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                    updateCmd.Parameters.AddWithValue("@Price", price);
                    updateCmd.Parameters.AddWithValue("@SubTotal", subtotal);
                    updateCmd.Parameters.AddWithValue("@CustomerID", Session.CustomerID);
                    updateCmd.Parameters.AddWithValue("@MedicineID", medicineID);

                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    // Insert new medicine into cart

                    string insertQuery = @"INSERT INTO Cart
                                  (CustomerID, MedicineID, Quantity, Price, SubTotal)
                                  VALUES
                                  (@CustomerID, @MedicineID, 1, @Price, @SubTotal)";

                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@CustomerID", Session.CustomerID);
                    insertCmd.Parameters.AddWithValue("@MedicineID", medicineID);
                    insertCmd.Parameters.AddWithValue("@Price", price);
                    insertCmd.Parameters.AddWithValue("@SubTotal", price);

                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Medicine added to cart successfully!");
            }
        }

        // event handlers for the search textbox to implement the placeholder text functionality
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search for medicines")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search for medicines";
                txtSearch.ForeColor = Color.Gray;
            }
        }


        // event handler for the search textbox to filter the medicines based on the search text
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;

            // If it's empty or matching the placeholder, show all records
            if (string.IsNullOrWhiteSpace(searchText) || searchText == "Search for medicines")
            {
                LoadMedicines("", cmbCategory.Text);
            }
            else
            {
                LoadMedicines(searchText, cmbCategory.Text);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
                LoadMedicines(txtSearch.Text, cmbCategory.Text);
        }

        private void flpMedicines_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

