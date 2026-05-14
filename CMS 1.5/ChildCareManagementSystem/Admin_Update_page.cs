using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChildCareManagementSystem
{
    public partial class Admin_Update_page : Form
    {
        string s1,s2;
        public Admin_Update_page()
        {
            InitializeComponent();
        }
        public Admin_Update_page(string ss1, string ss2)
        {
            s1 = ss1;
            s2 = ss2;
            InitializeComponent();
            LoadDetails();
        }

        private void LoadDetails() { 
            label4.Text= "Current username is '"+s1+"'\n"+"Current password is '"+s2+"'";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Profile_Page f1 = new Admin_Profile_Page(s1,s2);
            f1.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=MOZAHID\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
            string query = "DELETE FROM admin_table WHERE admin_username = @admin_username";

            string newuser =new_username_textBox.Text.Trim();
            string newpass= new_pass_textBox.Text.Trim();
            string newconpass=new_pass_confirm_textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newuser) || string.IsNullOrWhiteSpace(newpass) || string.IsNullOrWhiteSpace(newconpass))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newpass != newconpass)
            {
                MessageBox.Show("Password dosent match");
                return;
            }

            if(s1==newuser && s2 == newpass)
            {
                MessageBox.Show("New username and password can not be same as old,");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@admin_username", s1);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
            query = "INSERT INTO admin_table (admin_username, admin_pass) VALUES (@admin_username, @admin_pass)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@admin_username", newuser);
                    command.Parameters.AddWithValue("@admin_pass", newpass);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Username Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Admin_Update_page f1 = new Admin_Update_page(newuser, newpass);
                        f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create the profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }











        }
    }
}
