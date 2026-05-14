using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChildCareManagementSystem
{
    public partial class Admin_Login_Page : Form
    {
        public Admin_Login_Page()
        {
            InitializeComponent();
        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void admin_username_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void admin_login_button1_Click(object sender, EventArgs e)
        {
            string adminName = admin_username_textBox1.Text.Trim();
            string adminPass = admin_password_textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(adminName) || string.IsNullOrWhiteSpace(adminPass))
            {
                MessageBox.Show("Please enter both Username and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string connectionString = "data source=MOZAHID\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";

            //string query = "SELECT COUNT(*) FROM section WHERE Id = @Id AND Name = @Name";
            string query = "SELECT COUNT(*) FROM admin_table WHERE admin_username = @admin_username AND admin_pass COLLATE SQL_Latin1_General_CP1_CS_AS = @admin_pass";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@admin_username", adminName);
                    command.Parameters.AddWithValue("@admin_pass", adminPass);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                     
                        Admin_Profile_Page f3 = new Admin_Profile_Page(adminName,adminPass);
                        f3.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Id or Name.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Home_Page home = new Home_Page();
            home.Show();
            this.Hide();
        }

        private void admin_password_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
