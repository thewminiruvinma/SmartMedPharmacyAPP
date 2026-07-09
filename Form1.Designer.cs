namespace SmartMedPharmacyAPP
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.panelCard = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTomorrow = new System.Windows.Forms.Label();
            this.lblBrighter = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblBetter = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.SystemColors.Window;
            this.panelCard.Controls.Add(this.label4);
            this.panelCard.Controls.Add(this.label1);
            this.panelCard.Controls.Add(this.btn_customer);
            this.panelCard.Controls.Add(this.btn_Admin);
            this.panelCard.Controls.Add(this.label3);
            this.panelCard.Controls.Add(this.label2);
            this.panelCard.Controls.Add(this.pictureBox1);
            this.panelCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCard.Location = new System.Drawing.Point(0, 0);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(358, 448);
            this.panelCard.TabIndex = 0;
            this.panelCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCard_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(75, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Smart care for a healthier tomorrow.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(102, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your health, Our priority.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_customer.FlatAppearance.BorderSize = 0;
            this.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_customer.Location = new System.Drawing.Point(63, 348);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(220, 45);
            this.btn_customer.TabIndex = 5;
            this.btn_customer.Text = "Customer Portal";
            this.btn_customer.UseVisualStyleBackColor = false;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Admin.FlatAppearance.BorderSize = 0;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Location = new System.Drawing.Point(63, 297);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(220, 45);
            this.btn_Admin.TabIndex = 4;
            this.btn_Admin.Text = "Admin Portal";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(95, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select your role to continue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(44, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to SmartMed Pharmacy";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(79, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.button1);
            this.panelRight.Controls.Add(this.label7);
            this.panelRight.Controls.Add(this.lblTomorrow);
            this.panelRight.Controls.Add(this.lblBrighter);
            this.panelRight.Controls.Add(this.lblHealth);
            this.panelRight.Controls.Add(this.lblBetter);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(355, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(30);
            this.panelRight.Size = new System.Drawing.Size(501, 448);
            this.panelRight.TabIndex = 1;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(87, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trusted care, Quality medicines, \r\nAlways here for you.";
            // 
            // lblTomorrow
            // 
            this.lblTomorrow.AutoSize = true;
            this.lblTomorrow.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTomorrow.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblTomorrow.Location = new System.Drawing.Point(200, 214);
            this.lblTomorrow.Name = "lblTomorrow";
            this.lblTomorrow.Size = new System.Drawing.Size(151, 37);
            this.lblTomorrow.TabIndex = 5;
            this.lblTomorrow.Text = "Tomorrow";
            this.lblTomorrow.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblBrighter
            // 
            this.lblBrighter.AutoSize = true;
            this.lblBrighter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrighter.ForeColor = System.Drawing.Color.White;
            this.lblBrighter.Location = new System.Drawing.Point(83, 214);
            this.lblBrighter.Name = "lblBrighter";
            this.lblBrighter.Size = new System.Drawing.Size(123, 37);
            this.lblBrighter.TabIndex = 4;
            this.lblBrighter.Text = "Brighter";
            this.lblBrighter.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblHealth.Location = new System.Drawing.Point(172, 167);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(103, 37);
            this.lblHealth.TabIndex = 3;
            this.lblHealth.Text = "Health";
            // 
            // lblBetter
            // 
            this.lblBetter.AutoSize = true;
            this.lblBetter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetter.ForeColor = System.Drawing.Color.White;
            this.lblBetter.Location = new System.Drawing.Point(83, 167);
            this.lblBetter.Name = "lblBetter";
            this.lblBetter.Size = new System.Drawing.Size(97, 37);
            this.lblBetter.TabIndex = 2;
            this.lblBetter.Text = "Better";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(172, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Medicines";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(83, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Smart";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(856, 448);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblBetter;
        private System.Windows.Forms.Label lblTomorrow;
        private System.Windows.Forms.Label lblBrighter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

