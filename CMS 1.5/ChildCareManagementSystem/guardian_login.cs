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

namespace ChildCareManagementSystem
{
    public partial class guardian_login : Form
    {
        public guardian_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardian_signup l1 = new guardian_signup();
            l1.Show();
            this.Hide();
        }

        private void button_back_to_home_Click(object sender, EventArgs e)
        {
            Home_Page home = new Home_Page();
            home.Show();
            this.Hide();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string guardian_password = textBox_guardian_password.Text;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(guardian_password))
            {
                MessageBox.Show("Please enter both Id and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int guardian_id = Convert.ToInt32(textBox1.Text);

            string connectionString = "data source=MOZAHID\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
            string query = "SELECT COUNT(*) FROM guardian_table WHERE guardian_id = @guardian_id AND guardian_password COLLATE SQL_Latin1_General_CP1_CS_AS = @guardian_password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_id", guardian_id);
                    command.Parameters.AddWithValue("@guardian_password", guardian_password);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        guardian_home gh1 = new guardian_home(guardian_id);
                        gh1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Id or Name.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_guardian_id_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_guardian_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
