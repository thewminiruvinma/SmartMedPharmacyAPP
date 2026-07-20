namespace SmartMedPharmacyAPP
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.ordersbtn = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.Rightpanel = new System.Windows.Forms.Panel();
            this.flpMedicines = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.Searchpanel = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.Rightpanel.SuspendLayout();
            this.Searchpanel.SuspendLayout();
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
            this.Leftpanel.TabIndex = 0;
            this.Leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Leftpanel_Paint);
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
            this.ordersbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ordersbtn.FlatAppearance.BorderSize = 0;
            this.ordersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersbtn.ForeColor = System.Drawing.Color.White;
            this.ordersbtn.Location = new System.Drawing.Point(12, 204);
            this.ordersbtn.Name = "ordersbtn";
            this.ordersbtn.Size = new System.Drawing.Size(182, 49);
            this.ordersbtn.TabIndex = 3;
            this.ordersbtn.Text = "My Orders";
            this.ordersbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersbtn.UseVisualStyleBackColor = false;
            this.ordersbtn.Click += new System.EventHandler(this.ordersbtn_Click);
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
            this.Searchbtn.BackColor = System.Drawing.Color.BurlyWood;
            this.Searchbtn.FlatAppearance.BorderSize = 0;
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Searchbtn.Location = new System.Drawing.Point(12, 104);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(182, 49);
            this.Searchbtn.TabIndex = 1;
            this.Searchbtn.Text = "Search Medicines";
            this.Searchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Searchbtn.UseVisualStyleBackColor = false;
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
            this.Rightpanel.Controls.Add(this.flpMedicines);
            this.Rightpanel.Controls.Add(this.label1);
            this.Rightpanel.Controls.Add(this.labelTitle);
            this.Rightpanel.Controls.Add(this.Searchpanel);
            this.Rightpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rightpanel.Location = new System.Drawing.Point(214, 0);
            this.Rightpanel.Name = "Rightpanel";
            this.Rightpanel.Size = new System.Drawing.Size(610, 450);
            this.Rightpanel.TabIndex = 1;
            // 
            // flpMedicines
            // 
            this.flpMedicines.AutoScroll = true;
            this.flpMedicines.BackColor = System.Drawing.Color.White;
            this.flpMedicines.Location = new System.Drawing.Point(19, 154);
            this.flpMedicines.Name = "flpMedicines";
            this.flpMedicines.Size = new System.Drawing.Size(566, 271);
            this.flpMedicines.TabIndex = 7;
            this.flpMedicines.Paint += new System.Windows.Forms.PaintEventHandler(this.flpMedicines_Paint);
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
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelTitle.Location = new System.Drawing.Point(21, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(239, 37);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Search Medicines";
            // 
            // Searchpanel
            // 
            this.Searchpanel.BackColor = System.Drawing.Color.White;
            this.Searchpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Searchpanel.Controls.Add(this.cmbCategory);
            this.Searchpanel.Controls.Add(this.txtSearch);
            this.Searchpanel.Location = new System.Drawing.Point(19, 79);
            this.Searchpanel.Name = "Searchpanel";
            this.Searchpanel.Size = new System.Drawing.Size(560, 51);
            this.Searchpanel.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(385, 12);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(153, 23);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.Rightpanel);
            this.Controls.Add(this.Leftpanel);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.Leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.Rightpanel.ResumeLayout(false);
            this.Rightpanel.PerformLayout();
            this.Searchpanel.ResumeLayout(false);
            this.Searchpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Panel Rightpanel;
        private System.Windows.Forms.Panel Searchpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.Button ordersbtn;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.FlowLayoutPanel flpMedicines;
    }
}