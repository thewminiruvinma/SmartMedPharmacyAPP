namespace SmartMedPharmacyAPP
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.panelSales = new System.Windows.Forms.Panel();
            this.Growthpanel = new System.Windows.Forms.Panel();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblTotalCustomersTitle = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Orderspanel = new System.Windows.Forms.Panel();
            this.lblActiveOrders = new System.Windows.Forms.Label();
            this.lblActiveOrdersTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Stockpanel = new System.Windows.Forms.Panel();
            this.lblMedicineStock = new System.Windows.Forms.Label();
            this.lblMedicineStockTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Salespanel = new System.Windows.Forms.Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconpanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSales.SuspendLayout();
            this.Growthpanel.SuspendLayout();
            this.Orderspanel.SuspendLayout();
            this.Stockpanel.SuspendLayout();
            this.Salespanel.SuspendLayout();
            this.iconpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnOrders);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnCustomers);
            this.panelSidebar.Controls.Add(this.btnMedicine);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 450);
            this.panelSidebar.TabIndex = 0;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 78);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 370);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 80);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(12, 293);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(220, 41);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(12, 246);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(220, 41);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDashboard.Location = new System.Drawing.Point(12, 117);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 41);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(12, 199);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(220, 41);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicine.FlatAppearance.BorderSize = 0;
            this.btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.ForeColor = System.Drawing.Color.White;
            this.btnMedicine.Location = new System.Drawing.Point(12, 157);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(220, 41);
            this.btnMedicine.TabIndex = 3;
            this.btnMedicine.Text = "Medicine";
            this.btnMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicine.UseVisualStyleBackColor = false;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // panelSales
            // 
            this.panelSales.Controls.Add(this.Growthpanel);
            this.panelSales.Controls.Add(this.Orderspanel);
            this.panelSales.Controls.Add(this.Stockpanel);
            this.panelSales.Controls.Add(this.Salespanel);
            this.panelSales.Controls.Add(this.label4);
            this.panelSales.Controls.Add(this.label3);
            this.panelSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSales.Location = new System.Drawing.Point(250, 0);
            this.panelSales.Name = "panelSales";
            this.panelSales.Size = new System.Drawing.Size(550, 450);
            this.panelSales.TabIndex = 1;
            // 
            // Growthpanel
            // 
            this.Growthpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Growthpanel.Controls.Add(this.lblTotalCustomers);
            this.Growthpanel.Controls.Add(this.lblTotalCustomersTitle);
            this.Growthpanel.Controls.Add(this.panel7);
            this.Growthpanel.Location = new System.Drawing.Point(282, 264);
            this.Growthpanel.Name = "Growthpanel";
            this.Growthpanel.Size = new System.Drawing.Size(242, 124);
            this.Growthpanel.TabIndex = 5;
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.Location = new System.Drawing.Point(105, 52);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(88, 30);
            this.lblTotalCustomers.TabIndex = 2;
            this.lblTotalCustomers.Text = "+12.5%";
            // 
            // lblTotalCustomersTitle
            // 
            this.lblTotalCustomersTitle.AutoSize = true;
            this.lblTotalCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomersTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTotalCustomersTitle.Location = new System.Drawing.Point(62, 17);
            this.lblTotalCustomersTitle.Name = "lblTotalCustomersTitle";
            this.lblTotalCustomersTitle.Size = new System.Drawing.Size(102, 17);
            this.lblTotalCustomersTitle.TabIndex = 1;
            this.lblTotalCustomersTitle.Text = "Total Customers";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Goldenrod;
            this.panel7.Location = new System.Drawing.Point(20, 19);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(37, 33);
            this.panel7.TabIndex = 0;
            // 
            // Orderspanel
            // 
            this.Orderspanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Orderspanel.Controls.Add(this.lblActiveOrders);
            this.Orderspanel.Controls.Add(this.lblActiveOrdersTitle);
            this.Orderspanel.Controls.Add(this.panel6);
            this.Orderspanel.Location = new System.Drawing.Point(29, 264);
            this.Orderspanel.Name = "Orderspanel";
            this.Orderspanel.Size = new System.Drawing.Size(242, 124);
            this.Orderspanel.TabIndex = 4;
            // 
            // lblActiveOrders
            // 
            this.lblActiveOrders.AutoSize = true;
            this.lblActiveOrders.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveOrders.Location = new System.Drawing.Point(152, 52);
            this.lblActiveOrders.Name = "lblActiveOrders";
            this.lblActiveOrders.Size = new System.Drawing.Size(37, 30);
            this.lblActiveOrders.TabIndex = 2;
            this.lblActiveOrders.Text = "86";
            // 
            // lblActiveOrdersTitle
            // 
            this.lblActiveOrdersTitle.AutoSize = true;
            this.lblActiveOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveOrdersTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblActiveOrdersTitle.Location = new System.Drawing.Point(62, 17);
            this.lblActiveOrdersTitle.Name = "lblActiveOrdersTitle";
            this.lblActiveOrdersTitle.Size = new System.Drawing.Size(87, 17);
            this.lblActiveOrdersTitle.TabIndex = 1;
            this.lblActiveOrdersTitle.Text = "Active Orders";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Violet;
            this.panel6.Location = new System.Drawing.Point(20, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(37, 33);
            this.panel6.TabIndex = 0;
            // 
            // Stockpanel
            // 
            this.Stockpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Stockpanel.Controls.Add(this.lblMedicineStock);
            this.Stockpanel.Controls.Add(this.lblMedicineStockTitle);
            this.Stockpanel.Controls.Add(this.panel5);
            this.Stockpanel.Location = new System.Drawing.Point(282, 117);
            this.Stockpanel.Name = "Stockpanel";
            this.Stockpanel.Size = new System.Drawing.Size(242, 124);
            this.Stockpanel.TabIndex = 3;
            // 
            // lblMedicineStock
            // 
            this.lblMedicineStock.AutoSize = true;
            this.lblMedicineStock.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineStock.Location = new System.Drawing.Point(125, 52);
            this.lblMedicineStock.Name = "lblMedicineStock";
            this.lblMedicineStock.Size = new System.Drawing.Size(67, 30);
            this.lblMedicineStock.TabIndex = 3;
            this.lblMedicineStock.Text = "1,248";
            // 
            // lblMedicineStockTitle
            // 
            this.lblMedicineStockTitle.AutoSize = true;
            this.lblMedicineStockTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineStockTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMedicineStockTitle.Location = new System.Drawing.Point(62, 17);
            this.lblMedicineStockTitle.Name = "lblMedicineStockTitle";
            this.lblMedicineStockTitle.Size = new System.Drawing.Size(110, 17);
            this.lblMedicineStockTitle.TabIndex = 2;
            this.lblMedicineStockTitle.Text = "Medicine in Stock";
            this.lblMedicineStockTitle.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(20, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(37, 33);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // Salespanel
            // 
            this.Salespanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Salespanel.Controls.Add(this.lblTotalSales);
            this.Salespanel.Controls.Add(this.lblTitle);
            this.Salespanel.Controls.Add(this.iconpanel);
            this.Salespanel.Location = new System.Drawing.Point(28, 117);
            this.Salespanel.Name = "Salespanel";
            this.Salespanel.Size = new System.Drawing.Size(242, 124);
            this.Salespanel.TabIndex = 2;
            this.Salespanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(93, 52);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(91, 30);
            this.lblTotalSales.TabIndex = 2;
            this.lblTotalSales.Text = "$24,580";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(62, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Total Sales";
            this.lblTitle.Click += new System.EventHandler(this.label6_Click);
            // 
            // iconpanel
            // 
            this.iconpanel.BackColor = System.Drawing.Color.LimeGreen;
            this.iconpanel.Controls.Add(this.label5);
            this.iconpanel.Location = new System.Drawing.Point(19, 17);
            this.iconpanel.Name = "iconpanel";
            this.iconpanel.Size = new System.Drawing.Size(37, 33);
            this.iconpanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label4.Location = new System.Drawing.Point(42, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Welcome back, Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(28, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dashboard";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSales);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSales.ResumeLayout(false);
            this.panelSales.PerformLayout();
            this.Growthpanel.ResumeLayout(false);
            this.Growthpanel.PerformLayout();
            this.Orderspanel.ResumeLayout(false);
            this.Orderspanel.PerformLayout();
            this.Stockpanel.ResumeLayout(false);
            this.Stockpanel.PerformLayout();
            this.Salespanel.ResumeLayout(false);
            this.Salespanel.PerformLayout();
            this.iconpanel.ResumeLayout(false);
            this.iconpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSales;
        private System.Windows.Forms.Panel Salespanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Growthpanel;
        private System.Windows.Forms.Panel Orderspanel;
        private System.Windows.Forms.Panel Stockpanel;
        private System.Windows.Forms.Panel iconpanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMedicineStockTitle;
        private System.Windows.Forms.Label lblMedicineStock;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblActiveOrdersTitle;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTotalCustomersTitle;
        private System.Windows.Forms.Label lblActiveOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}