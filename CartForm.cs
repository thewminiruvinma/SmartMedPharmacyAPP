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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        private void medicinelbl_Click(object sender, EventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
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

        private void CartForm_Load(object sender, EventArgs e)
        {
            LoadCart();
        }

        private void LoadCart()
        {
            flowCart.Controls.Clear();

            decimal total = 0;

            using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                                @"SELECT
                        c.CartID,
                        m.Name,
                        m.Price,
                        c.Quantity
                        FROM Cart c
                        JOIN Medicine m
                        ON c.MedicineID = m.MedicineID
                        WHERE c.CustomerID=@CustomerID";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerID", Session.CustomerID);

                MySqlDataReader reader = cmd.ExecuteReader();

                bool hasItems = false;

                while (reader.Read())
                {
                    hasItems = true;

                    Panel card = CreateCartCard(
                        Convert.ToInt32(reader["CartID"]),
                        reader["Name"].ToString(),
                        Convert.ToDecimal(reader["Price"]),
                        Convert.ToInt32(reader["Quantity"])
                    );

                    flowCart.Controls.Add(card);

                    total +=
                    Convert.ToDecimal(reader["Price"])
                    *
                    Convert.ToInt32(reader["Quantity"]);
                }

                lblEmptyCart.Visible = !hasItems;

                lblTotal.Text =
                "Total : Rs." + total.ToString("0.00");
            }

            if (flowCart.Controls.Count == 0)
            {
                lblEmptyCart.Visible = true;
            }
            else
            {
                lblEmptyCart.Visible = false;
            }
        }

        private Panel CreateCartCard(int cartID, string medicineName, decimal price, int quantity)
        {
            // create the panel card for the medicine item in the cart
            Panel card = new Panel();

            card.Width = 700;
            card.Height = 120;
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);

            // create the labels and buttons for the card
            Label lblName = new Label();

            lblName.Text = medicineName;
            lblName.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblName.Location = new Point(20, 20);
            lblName.AutoSize = true;

            Label lblPrice = new Label();

            lblPrice.Text = "Rs. " + price.ToString("0.00");
            lblPrice.Font = new Font("Segoe UI", 12);
            lblPrice.Location = new Point(20, 60);
            lblPrice.AutoSize = true;

            Button btnMinus = new Button();

            btnMinus.Text = "-";
            btnMinus.Width = 35;
            btnMinus.Height = 35;
            btnMinus.Location = new Point(450, 45);

            Label lblQty = new Label();

            lblQty.Text = quantity.ToString();
            lblQty.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblQty.Location = new Point(500, 52);
            lblQty.AutoSize = true;

            Button btnPlus = new Button();

            btnPlus.Text = "+";
            btnPlus.Width = 35;
            btnPlus.Height = 35;
            btnPlus.Location = new Point(550, 45);

            Button btnDelete = new Button();

            btnDelete.Text = "Delete";
            btnDelete.Width = 70;
            btnDelete.Height = 35;
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;

            btnDelete.Location = new Point(620, 45);

            // add event handlers for the buttons
            card.Controls.Add(lblName);
            card.Controls.Add(lblPrice);

            card.Controls.Add(btnMinus);
            card.Controls.Add(lblQty);
            card.Controls.Add(btnPlus);

            card.Controls.Add(btnDelete);

            // Plus button
            btnPlus.Click += (s, e) =>
            {
                UpdateQuantity(cartID, 1);
            };

            // Minus button
            btnMinus.Click += (s, e) =>
            {
                UpdateQuantity(cartID, -1);
            };

            // Delete button
            btnDelete.Click += (s, e) =>
            {
                DeleteCartItem(cartID);
            };

            return card;

        }

        // Update quantity of cart item
        private void UpdateQuantity(int cartID, int change)
        {
            using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                // Get current quantity and price
                string selectQuery = @"SELECT Quantity, Price
                               FROM Cart
                               WHERE CartID=@CartID";

                MySqlCommand selectCmd = new MySqlCommand(selectQuery, con);
                selectCmd.Parameters.AddWithValue("@CartID", cartID);

                MySqlDataReader reader = selectCmd.ExecuteReader();

                if (!reader.Read())
                    return;

                int quantity = Convert.ToInt32(reader["Quantity"]);
                decimal price = Convert.ToDecimal(reader["Price"]);

                reader.Close();

                quantity += change;

                // Remove item if quantity becomes 0
                if (quantity <= 0)
                {
                    DeleteCartItem(cartID);
                    return;
                }

                decimal subtotal = quantity * price;

                string updateQuery = @"UPDATE Cart
                               SET Quantity=@Quantity,
                                   SubTotal=@SubTotal
                               WHERE CartID=@CartID";

                MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);

                updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                updateCmd.Parameters.AddWithValue("@SubTotal", subtotal);
                updateCmd.Parameters.AddWithValue("@CartID", cartID);

                updateCmd.ExecuteNonQuery();
            }

            LoadCart();
        }

        // Delete cart item
        private void DeleteCartItem(int cartID)
        {
            DialogResult result = MessageBox.Show(
                "Remove this medicine from cart?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query = "DELETE FROM Cart WHERE CartID=@CartID";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CartID", cartID);

                cmd.ExecuteNonQuery();
            }

            LoadCart();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Check if customer has logged in
            if (Session.CustomerID == 0)
            {
                MessageBox.Show("Please login first.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(DBConnection.ConnectionString))
                {
                    con.Open();

                    // Check if cart is empty BEFORE starting a transaction
                    string checkCartQuery = @"SELECT COUNT(*) FROM Cart WHERE CustomerID=@CustomerID";
                    using (MySqlCommand checkCartCmd = new MySqlCommand(checkCartQuery, con))
                    {
                        checkCartCmd.Parameters.AddWithValue("@CustomerID", Session.CustomerID);
                        int cartCount = Convert.ToInt32(checkCartCmd.ExecuteScalar());

                        if (cartCount == 0)
                        {
                            MessageBox.Show(
                                "Your cart is empty.",
                                "Checkout",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return; // Clean exit without transaction issues
                        }
                    }

                    // Ask for confirmation ONLY if cart has items
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to place this order?",
                        "Confirm Checkout",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                        return;

                    // Start Transaction now that we know we have work to do
                    using (MySqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // Calculate Total Amount
                            string totalQuery = @"SELECT IFNULL(SUM(SubTotal),0) FROM Cart WHERE CustomerID=@CustomerID";
                            MySqlCommand totalCmd = new MySqlCommand(totalQuery, con, transaction);
                            totalCmd.Parameters.AddWithValue("@CustomerID", Session.CustomerID);
                            decimal total = Convert.ToDecimal(totalCmd.ExecuteScalar());

                            // Create Order
                            string orderQuery = @"INSERT INTO Orders (CustomerID, OrderDate, TotalAmount, Status)
                                          VALUES (@CustomerID, @OrderDate, @TotalAmount, 'Processing')";
                            MySqlCommand orderCmd = new MySqlCommand(orderQuery, con, transaction);
                            orderCmd.Parameters.AddWithValue("@CustomerID", Session.CustomerID);
                            orderCmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                            orderCmd.Parameters.AddWithValue("@TotalAmount", total);
                            orderCmd.ExecuteNonQuery();

                            int orderID = Convert.ToInt32(orderCmd.LastInsertedId);

                            // Read Customer Cart
                            string cartQuery = @"SELECT * FROM Cart WHERE CustomerID=@CustomerID";
                            MySqlCommand cartCmd = new MySqlCommand(cartQuery, con, transaction);
                            cartCmd.Parameters.AddWithValue("@CustomerID", Session.CustomerID);

                            DataTable cartTable = new DataTable();
                            using (MySqlDataReader reader = cartCmd.ExecuteReader())
                            {
                                cartTable.Load(reader);
                            }

                            // Save Order Items & Adjust Stock
                            foreach (DataRow row in cartTable.Rows)
                            {
                                // Check Medicine Stock
                                string stockCheck = @"SELECT Name, StockQuantity FROM Medicine WHERE MedicineID=@MedicineID";
                                MySqlCommand stockCheckCmd = new MySqlCommand(stockCheck, con, transaction);
                                stockCheckCmd.Parameters.AddWithValue("@MedicineID", row["MedicineID"]);

                                using (MySqlDataReader reader = stockCheckCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string medicineName = reader["Name"].ToString();
                                        int currentStock = Convert.ToInt32(reader["StockQuantity"]);
                                        int orderedQty = Convert.ToInt32(row["Quantity"]);

                                        // Handle completely out of stock
                                        if (currentStock <= 0)
                                        {
                                            throw new Exception($"'{medicineName}' is currently out of stock and cannot be purchased.");
                                        }

                                        // Handle insufficient stock
                                        if (orderedQty > currentStock)
                                        {
                                            throw new Exception($"Only {currentStock} unit(s) left in stock for '{medicineName}'. Please adjust your cart.");
                                        }
                                    }
                                }

                                // Insert into OrderItems
                                string itemQuery = @"INSERT INTO OrderItems (OrderID, MedicineID, Quantity, UnitPrice)
                                             VALUES (@OrderID, @MedicineID, @Quantity, @UnitPrice)";
                                MySqlCommand itemCmd = new MySqlCommand(itemQuery, con, transaction);
                                itemCmd.Parameters.AddWithValue("@OrderID", orderID);
                                itemCmd.Parameters.AddWithValue("@MedicineID", row["MedicineID"]);
                                itemCmd.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                                itemCmd.Parameters.AddWithValue("@UnitPrice", row["Price"]);
                                itemCmd.ExecuteNonQuery();

                                // Reduce Medicine Stock
                                string updateStock = @"UPDATE Medicine SET StockQuantity = StockQuantity - @Quantity WHERE MedicineID=@MedicineID";
                                MySqlCommand stockCmd = new MySqlCommand(updateStock, con, transaction);
                                stockCmd.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                                stockCmd.Parameters.AddWithValue("@MedicineID", row["MedicineID"]);
                                stockCmd.ExecuteNonQuery();
                            }

                            // Clear Customer Cart
                            string deleteCart = @"DELETE FROM Cart WHERE CustomerID=@CustomerID";
                            MySqlCommand deleteCmd = new MySqlCommand(deleteCart, con, transaction);
                            deleteCmd.Parameters.AddWithValue("@CustomerID", Session.CustomerID);
                            deleteCmd.ExecuteNonQuery();

                            // Commit Transaction
                            transaction.Commit();

                            // Refresh UI & Display Success
                            LoadCart();
                            MessageBox.Show(
                                "🎉 Your order has been placed successfully!",
                                "Order Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw; // Passes error to outer catch block cleanly
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Checkout Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
