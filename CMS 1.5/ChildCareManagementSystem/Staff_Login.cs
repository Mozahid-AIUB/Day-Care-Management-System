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
    public partial class Staff_Login : Form
    {
        public Staff_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staff sss = new staff();
            this.Hide();
            sss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string staff_pass = textBox_guardian_password.Text;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(staff_pass))
            {
                MessageBox.Show("Please enter both Id and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int staff_id = Convert.ToInt32(textBox1.Text);

            string connectionString = "data source=YASSER\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
            string query = "SELECT COUNT(*) FROM staff_table WHERE staff_id = @staff_id AND staff_password COLLATE SQL_Latin1_General_CP1_CS_AS = @staff_password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@staff_id", staff_id);
                    command.Parameters.AddWithValue("@staff_password", staff_pass);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        staff_home gh1 = new staff_home(staff_id);
                        gh1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Id or Name.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox_guardian_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
