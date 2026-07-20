namespace SmartMedPharmacyAPP
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.ordersbtn = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.Rightpanel = new System.Windows.Forms.Panel();
            this.panelProfileInfo = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblProfileInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProfile = new System.Windows.Forms.Label();
            this.Leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.Rightpanel.SuspendLayout();
            this.panelProfileInfo.SuspendLayout();
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
            this.Leftpanel.TabIndex = 3;
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
            this.ProfileBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.ProfileBtn.FlatAppearance.BorderSize = 0;
            this.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProfileBtn.Location = new System.Drawing.Point(12, 255);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(182, 49);
            this.ProfileBtn.TabIndex = 4;
            this.ProfileBtn.Text = "Profile";
            this.ProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileBtn.UseVisualStyleBackColor = false;
            // 
            // ordersbtn
            // 
            this.ordersbtn.BackColor = System.Drawing.Color.Transparent;
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
            this.Rightpanel.Controls.Add(this.panelProfileInfo);
            this.Rightpanel.Controls.Add(this.label1);
            this.Rightpanel.Controls.Add(this.labelProfile);
            this.Rightpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rightpanel.Location = new System.Drawing.Point(214, 0);
            this.Rightpanel.Name = "Rightpanel";
            this.Rightpanel.Size = new System.Drawing.Size(616, 450);
            this.Rightpanel.TabIndex = 4;
            // 
            // panelProfileInfo
            // 
            this.panelProfileInfo.BackColor = System.Drawing.Color.White;
            this.panelProfileInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelProfileInfo.Controls.Add(this.btnUpdate);
            this.panelProfileInfo.Controls.Add(this.txtAddress);
            this.panelProfileInfo.Controls.Add(this.txtPhone);
            this.panelProfileInfo.Controls.Add(this.txtEmail);
            this.panelProfileInfo.Controls.Add(this.txtFullName);
            this.panelProfileInfo.Controls.Add(this.lblProfileInfo);
            this.panelProfileInfo.Location = new System.Drawing.Point(32, 91);
            this.panelProfileInfo.Name = "panelProfileInfo";
            this.panelProfileInfo.Size = new System.Drawing.Size(560, 328);
            this.panelProfileInfo.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(58, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(432, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(58, 162);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(432, 81);
            this.txtAddress.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(58, 131);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(432, 25);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(58, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(432, 25);
            this.txtEmail.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(58, 63);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(432, 25);
            this.txtFullName.TabIndex = 1;
            // 
            // lblProfileInfo
            // 
            this.lblProfileInfo.AutoSize = true;
            this.lblProfileInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileInfo.Location = new System.Drawing.Point(13, 17);
            this.lblProfileInfo.Name = "lblProfileInfo";
            this.lblProfileInfo.Size = new System.Drawing.Size(203, 30);
            this.lblProfileInfo.TabIndex = 0;
            this.lblProfileInfo.Text = "Profile Information";
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
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelProfile.Location = new System.Drawing.Point(21, 9);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(103, 37);
            this.labelProfile.TabIndex = 1;
            this.labelProfile.Text = "Profile";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.Rightpanel);
            this.Controls.Add(this.Leftpanel);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.Leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.Rightpanel.ResumeLayout(false);
            this.Rightpanel.PerformLayout();
            this.panelProfileInfo.ResumeLayout(false);
            this.panelProfileInfo.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelProfileInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblProfileInfo;
        private System.Windows.Forms.Button btnUpdate;
    }
}