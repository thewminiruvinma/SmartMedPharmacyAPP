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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace SmartMedPharmacyAPP
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
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
            ManageMedicineForm customers = new ManageMedicineForm(); 
            customers.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ManageOrdersForm orders = new ManageOrdersForm();
            orders.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AdminLoginForm login = new AdminLoginForm();
            login.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panelInventory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOutOfStoc_Click(object sender, EventArgs e)
        {
            ForeColor = Color.Red;
        }

        private void label15lblWellStocked_Click(object sender, EventArgs e)
        {
            ForeColor = Color.Green;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadReportCards();

            LoadSalesReport();
        }

        // Load the report cards with data from the database
        private void LoadReportCards()
        {
            LoadTotalSales();

            LoadCustomers();

            LoadMedicines();

            LoadOrders();
        }

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

                MySqlCommand cmd =
                    new MySqlCommand(query, con);

                decimal total =
                    Convert.ToDecimal(cmd.ExecuteScalar());

                lblTotalSales.Text =
                    "Rs. " + total.ToString("N2");
            }
        }

        private void LoadCustomers()
        {
            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                "SELECT COUNT(*) FROM Customer";

                MySqlCommand cmd =
                    new MySqlCommand(query, con);

                lblCustomers.Text =
                    cmd.ExecuteScalar().ToString();
            }
        }

        private void LoadMedicines()
        {
            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                "SELECT COUNT(*) FROM Medicine";

                MySqlCommand cmd =
                    new MySqlCommand(query, con);

                lblMedicines.Text =
                    cmd.ExecuteScalar().ToString();
            }
        }

        private void LoadOrders()
        {
            using (MySqlConnection con =
                new MySqlConnection(DBConnection.ConnectionString))
            {
                con.Open();

                string query =
                "SELECT COUNT(*) FROM Orders";

                MySqlCommand cmd =
                    new MySqlCommand(query, con);

                lblOrders.Text =
                    cmd.ExecuteScalar().ToString();
            }
        }

        // Load the sales report data into the DataGridView
        private void LoadSalesReport()
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

        ON o.CustomerID=c.CustomerID";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvReports.DataSource = dt;

                dgvReports.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvReports.ReadOnly = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReportCards();

            LoadSalesReport();
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            // Create Save File Dialog
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF Files (*.pdf)|*.pdf";
            save.Title = "Save SmartMed Report";
            save.FileName = "SmartMed_Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Create PDF document
                    Document document = new Document(PageSize.A4, 30, 30, 40, 40);

                    // parameter structure for GetInstance
                    using (FileStream fs = new FileStream(save.FileName, FileMode.Create))
                    {
                        PdfWriter.GetInstance(document, fs);

                        document.Open();

                        // Fonts
                       
                        iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22);
                        iTextSharp.text.Font headingFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                        iTextSharp.text.Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);
                        iTextSharp.text.Font footerFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10);

                        // Title
                      
                        Paragraph title = new Paragraph("SMARTMED PHARMACY", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        document.Add(title);

                        Paragraph subtitle = new Paragraph("SALES & ORDER REPORT", headingFont);
                        subtitle.Alignment = Element.ALIGN_CENTER;
                        document.Add(subtitle);

                        document.Add(new Paragraph(" "));

                        // Report Information
                       
                        document.Add(new Paragraph("Generated On : " + DateTime.Now.ToString("dd MMMM yyyy  hh:mm tt"), normalFont));
                        document.Add(new Paragraph("Generated By : " + Session.AdminUsername, normalFont));
                        document.Add(new Paragraph(" "));

                       
                        // Summary Section

                        Paragraph summaryTitle = new Paragraph("REPORT SUMMARY", headingFont);
                        document.Add(summaryTitle);

                        document.Add(new Paragraph("----------------------------------------------------------"));
                        document.Add(new Paragraph("Total Sales      : " + lblTotalSales.Text, normalFont));
                        document.Add(new Paragraph("Total Customers  : " + lblCustomers.Text, normalFont));
                        document.Add(new Paragraph("Total Medicines  : " + lblMedicines.Text, normalFont));
                        document.Add(new Paragraph("Total Orders     : " + lblOrders.Text, normalFont));
                        document.Add(new Paragraph(" "));

                        // Orders Table Title
                        
                        Paragraph tableTitle = new Paragraph("ORDER DETAILS", headingFont);
                        document.Add(tableTitle);
                        document.Add(new Paragraph(" "));

                        // Create PDF Table
                        
                        PdfPTable table = new PdfPTable(dgvReports.Columns.Count);
                        table.WidthPercentage = 100;

                        // Add Column Headers

                        foreach (DataGridViewColumn column in dgvReports.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));

                            // Changed BaseColor format to match iTextSharp naming specs
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }

                        // Add Rows
                        
                        foreach (DataGridViewRow row in dgvReports.Rows)
                        {
                            if (row.IsNewRow)
                                continue;

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(cell.Value?.ToString() ?? "");
                            }
                        }

                        document.Add(table);
                        document.Add(new Paragraph(" "));

                        // Footer
                        
                        Paragraph footer = new Paragraph("This report was automatically generated by the SmartMed Pharmacy Management System.\n\nThank you.", footerFont);
                        footer.Alignment = Element.ALIGN_CENTER;
                        document.Add(footer);

                        // Close Document
                        
                        document.Close();
                    }

                    // Success Message
                    MessageBox.Show("PDF Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open PDF Automatically
                    
                    // Modern systems require UseShellExecute = true to load files directly
                    Process.Start(new ProcessStartInfo(save.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
