namespace ChildCareManagementSystem
{
    partial class guardian_login
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_guardian_password = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_guardian_id = new System.Windows.Forms.Label();
            this.button_back_to_home = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(330, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_guardian_password
            // 
            this.textBox_guardian_password.Location = new System.Drawing.Point(255, 129);
            this.textBox_guardian_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_guardian_password.Name = "textBox_guardian_password";
            this.textBox_guardian_password.Size = new System.Drawing.Size(143, 20);
            this.textBox_guardian_password.TabIndex = 14;
            this.textBox_guardian_password.TextChanged += new System.EventHandler(this.textBox_guardian_password_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 67);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_guardian_id
            // 
            this.label_guardian_id.AutoSize = true;
            this.label_guardian_id.BackColor = System.Drawing.Color.RosyBrown;
            this.label_guardian_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_guardian_id.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_guardian_id.Location = new System.Drawing.Point(194, 68);
            this.label_guardian_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_guardian_id.Name = "label_guardian_id";
            this.label_guardian_id.Size = new System.Drawing.Size(33, 19);
            this.label_guardian_id.TabIndex = 11;
            this.label_guardian_id.Text = "ID :";
            this.label_guardian_id.Click += new System.EventHandler(this.label_guardian_id_Click);
            // 
            // button_back_to_home
            // 
            this.button_back_to_home.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back_to_home.Location = new System.Drawing.Point(72, 280);
            this.button_back_to_home.Margin = new System.Windows.Forms.Padding(2);
            this.button_back_to_home.Name = "button_back_to_home";
            this.button_back_to_home.Size = new System.Drawing.Size(56, 26);
            this.button_back_to_home.TabIndex = 10;
            this.button_back_to_home.Text = "Back";
            this.button_back_to_home.UseVisualStyleBackColor = true;
            this.button_back_to_home.Click += new System.EventHandler(this.button_back_to_home_Click);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.DarkOrchid;
            this.button_login.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_login.Location = new System.Drawing.Point(168, 214);
            this.button_login.Margin = new System.Windows.Forms.Padding(2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(95, 34);
            this.button_login.TabIndex = 9;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChildCareManagementSystem.Properties.Resources.guardian_login;
            this.pictureBox1.Location = new System.Drawing.Point(0, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guardian_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_guardian_password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_guardian_id);
            this.Controls.Add(this.button_back_to_home);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "guardian_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardian Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_guardian_password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_guardian_id;
        private System.Windows.Forms.Button button_back_to_home;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}