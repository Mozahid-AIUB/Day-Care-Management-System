namespace ChildCareManagementSystem
{
    partial class Admin_Login_Page
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
            this.admin_username_textBox1 = new System.Windows.Forms.TextBox();
            this.admin_password_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_login_button1 = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_username_textBox1
            // 
            this.admin_username_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.admin_username_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.admin_username_textBox1.Location = new System.Drawing.Point(250, 124);
            this.admin_username_textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.admin_username_textBox1.Name = "admin_username_textBox1";
            this.admin_username_textBox1.Size = new System.Drawing.Size(187, 26);
            this.admin_username_textBox1.TabIndex = 1;
            this.admin_username_textBox1.TextChanged += new System.EventHandler(this.admin_username_textBox1_TextChanged);
            // 
            // admin_password_textBox2
            // 
            this.admin_password_textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.admin_password_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.admin_password_textBox2.Location = new System.Drawing.Point(250, 176);
            this.admin_password_textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.admin_password_textBox2.Name = "admin_password_textBox2";
            this.admin_password_textBox2.Size = new System.Drawing.Size(187, 26);
            this.admin_password_textBox2.TabIndex = 2;
            this.admin_password_textBox2.TextChanged += new System.EventHandler(this.admin_password_textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label2.Location = new System.Drawing.Point(110, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(110, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // admin_login_button1
            // 
            this.admin_login_button1.BackColor = System.Drawing.Color.DimGray;
            this.admin_login_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_login_button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.admin_login_button1.FlatAppearance.BorderSize = 0;
            this.admin_login_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admin_login_button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.admin_login_button1.Location = new System.Drawing.Point(302, 242);
            this.admin_login_button1.Margin = new System.Windows.Forms.Padding(2);
            this.admin_login_button1.Name = "admin_login_button1";
            this.admin_login_button1.Size = new System.Drawing.Size(73, 36);
            this.admin_login_button1.TabIndex = 6;
            this.admin_login_button1.Text = "Login";
            this.admin_login_button1.UseVisualStyleBackColor = false;
            this.admin_login_button1.Click += new System.EventHandler(this.admin_login_button1_Click);
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.home_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.home_button.Location = new System.Drawing.Point(9, 10);
            this.home_button.Margin = new System.Windows.Forms.Padding(2);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(76, 41);
            this.home_button.TabIndex = 7;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChildCareManagementSystem.Properties.Resources.Admin_login_backgroung;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 369);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Admin_Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.admin_login_button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.admin_password_textBox2);
            this.Controls.Add(this.admin_username_textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin_Login_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login Page";
            this.Load += new System.EventHandler(this.Admin_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox admin_username_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox admin_password_textBox2;
        private System.Windows.Forms.Button admin_login_button1;
        private System.Windows.Forms.Button home_button;
    }
}