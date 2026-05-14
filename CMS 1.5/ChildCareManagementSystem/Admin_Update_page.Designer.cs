namespace ChildCareManagementSystem
{
    partial class Admin_Update_page
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.new_username_textBox = new System.Windows.Forms.TextBox();
            this.new_pass_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.new_pass_confirm_textBox = new System.Windows.Forms.TextBox();
            this.update_confirm_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChildCareManagementSystem.Properties.Resources.Admin_login_backgroung;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 372);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label2.Location = new System.Drawing.Point(46, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Username     ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(46, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Password     ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // new_username_textBox
            // 
            this.new_username_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.new_username_textBox.Location = new System.Drawing.Point(281, 165);
            this.new_username_textBox.Name = "new_username_textBox";
            this.new_username_textBox.Size = new System.Drawing.Size(233, 26);
            this.new_username_textBox.TabIndex = 7;
            // 
            // new_pass_textBox
            // 
            this.new_pass_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_pass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.new_pass_textBox.Location = new System.Drawing.Point(281, 214);
            this.new_pass_textBox.Name = "new_pass_textBox";
            this.new_pass_textBox.Size = new System.Drawing.Size(233, 26);
            this.new_pass_textBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label3.Location = new System.Drawing.Point(42, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirm Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // new_pass_confirm_textBox
            // 
            this.new_pass_confirm_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_pass_confirm_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.new_pass_confirm_textBox.Location = new System.Drawing.Point(281, 259);
            this.new_pass_confirm_textBox.Name = "new_pass_confirm_textBox";
            this.new_pass_confirm_textBox.Size = new System.Drawing.Size(233, 26);
            this.new_pass_confirm_textBox.TabIndex = 10;
            this.new_pass_confirm_textBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // update_confirm_button
            // 
            this.update_confirm_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.update_confirm_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_confirm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.update_confirm_button.Location = new System.Drawing.Point(327, 304);
            this.update_confirm_button.Name = "update_confirm_button";
            this.update_confirm_button.Size = new System.Drawing.Size(107, 36);
            this.update_confirm_button.TabIndex = 11;
            this.update_confirm_button.Text = "Confirm";
            this.update_confirm_button.UseVisualStyleBackColor = false;
            this.update_confirm_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label4.Location = new System.Drawing.Point(82, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "              ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.back_button.Location = new System.Drawing.Point(500, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(85, 36);
            this.back_button.TabIndex = 13;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin_Update_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 368);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.update_confirm_button);
            this.Controls.Add(this.new_pass_confirm_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_pass_textBox);
            this.Controls.Add(this.new_username_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin_Update_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Update Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox new_username_textBox;
        private System.Windows.Forms.TextBox new_pass_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox new_pass_confirm_textBox;
        private System.Windows.Forms.Button update_confirm_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back_button;
    }
}