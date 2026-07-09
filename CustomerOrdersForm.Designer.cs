using System;
using System.Drawing;

namespace SmartMedPharmacyAPP
{
    partial class CustomerOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrdersForm));
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.ordersbtn = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.Rightpanel = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOrders = new System.Windows.Forms.Label();
            this.Leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.Rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.Leftpanel.Controls.Add(this.logoutbtn);
            this.Leftpanel.Controls.Add(this.ProfileBtn);
            this.Leftpanel.Controls.Add(this.ordersbtn);
            this.Leftpanel.Controls.Add(this.btnCart);
            this.Leftpanel.Controls.Add(this.Searchbtn);
            this.Leftpanel.Controls.Add(this.picboxLogo);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(214, 450);
            this.Leftpanel.TabIndex = 2;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.White;
            this.logoutbtn.Location = new System.Drawing.Point(12, 395);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(182, 49);
            this.logoutbtn.TabIndex = 5;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ProfileBtn.FlatAppearance.BorderSize = 0;
            this.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBtn.ForeColor = System.Drawing.Color.White;
            this.ProfileBtn.Location = new System.Drawing.Point(12, 255);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(182, 49);
            this.ProfileBtn.TabIndex = 4;
            this.ProfileBtn.Text = "Profile";
            this.ProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileBtn.UseVisualStyleBackColor = false;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // ordersbtn
            // 
            this.ordersbtn.BackColor = System.Drawing.Color.BurlyWood;
            this.ordersbtn.FlatAppearance.BorderSize = 0;
            this.ordersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersbtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ordersbtn.Location = new System.Drawing.Point(12, 204);
            this.ordersbtn.Name = "ordersbtn";
            this.ordersbtn.Size = new System.Drawing.Size(182, 49);
            this.ordersbtn.TabIndex = 3;
            this.ordersbtn.Text = "My Orders";
            this.ordersbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersbtn.UseVisualStyleBackColor = false;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Location = new System.Drawing.Point(12, 154);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(182, 49);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Cart\r\n";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.Searchbtn.FlatAppearance.BorderSize = 0;
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.Location = new System.Drawing.Point(12, 104);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(182, 49);
            this.Searchbtn.TabIndex = 1;
            this.Searchbtn.Text = "Search Medicines";
            this.Searchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picboxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxLogo.BackgroundImage")));
            this.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxLogo.Location = new System.Drawing.Point(0, 0);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(214, 85);
            this.picboxLogo.TabIndex = 0;
            this.picboxLogo.TabStop = false;
            // 
            // Rightpanel
            // 
            this.Rightpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Rightpanel.Controls.Add(this.dgvOrders);
            this.Rightpanel.Controls.Add(this.panelSearch);
            this.Rightpanel.Controls.Add(this.pnlNotifications);
            this.Rightpanel.Controls.Add(this.label1);
            this.Rightpanel.Controls.Add(this.labelOrders);
            this.Rightpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rightpanel.Location = new System.Drawing.Point(214, 0);
            this.Rightpanel.Name = "Rightpanel";
            this.Rightpanel.Size = new System.Drawing.Size(618, 450);
            this.Rightpanel.TabIndex = 3;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(32, 154);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(560, 271);
            this.dgvOrders.TabIndex = 8;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSearch.Controls.Add(this.cmbStatus);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Location = new System.Drawing.Point(32, 91);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(560, 51);
            this.panelSearch.TabIndex = 7;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(385, 12);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(153, 23);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            this.cmbStatus.Enter += new System.EventHandler(this.cmbStatus_Enter);
            this.cmbStatus.Leave += new System.EventHandler(this.cmbStatus_Leave);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.Location = new System.Drawing.Point(10, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(369, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearchOrders_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearchOrders_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearchOrders_Leave);
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.BackColor = System.Drawing.Color.Gray;
            this.pnlNotifications.Location = new System.Drawing.Point(421, 16);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(33, 30);
            this.pnlNotifications.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcom back, Customer.";
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrders.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelOrders.Location = new System.Drawing.Point(21, 9);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(151, 37);
            this.labelOrders.TabIndex = 1;
            this.labelOrders.Text = "My Orders";
            // 
            // CustomerOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.Rightpanel);
            this.Controls.Add(this.Leftpanel);
            this.Name = "CustomerOrdersForm";
            this.Text = "CustomerOrdersForm";
            this.Load += new System.EventHandler(this.CustomerOrdersForm_Load);
            this.Leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.Rightpanel.ResumeLayout(false);
            this.Rightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        // C#
        private void txtSearchOrders_TextChanged(object sender, EventArgs e)
        {
            string filterText = (txtSearch.Text == searchPlaceholder) ? "" : txtSearch.Text;
            string status = (cmbStatus.Text == "All Statuses" || string.IsNullOrWhiteSpace(cmbStatus.Text)) ? "" : cmbStatus.Text;

            LoadOrders(filterText, status);
        }

        private void txtSearchOrders_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == searchPlaceholder)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }   

        private void txtSearchOrders_Enter(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.Button ordersbtn;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Panel Rightpanel;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvOrders;
    }
}