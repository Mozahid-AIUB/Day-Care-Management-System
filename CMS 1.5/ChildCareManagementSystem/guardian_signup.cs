using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildCareManagementSystem
{
    public partial class guardian_signup : Form
    {
        string connectionString = "data source=MOZAHID\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
        public guardian_signup()
        {
            InitializeComponent();
        }

        private void button_back_to_login_Click(object sender, EventArgs e)
        {
            guardian_login l1 = new guardian_login();
            l1.Show();
            this.Hide();
        }

        private void button1_signup_Click(object sender, EventArgs e)
        {
            string guardian_password = textBox_guardian_password.Text.Trim();
            string guardian_f_name = textBox_guardian_f_name.Text.Trim();
            string guardian_l_name = textBox_guardian_l_name.Text.Trim();
            string guardian_nid = textBox_guardian_nid.Text.Trim();
            string guardian_phn_num = textBox_guardian_phn_num.Text.Trim();
            string guardian_email = textBox_guardian_email.Text.Trim();
            string guardian_address = richTextBox_guardian_address.Text.Trim();
            string guardian_emergency_num = textBox_guardian_emergency_num.Text.Trim();
            string guardian_profession = textBox_guardian_profession.Text.Trim();

            if (string.IsNullOrWhiteSpace(guardian_password) || string.IsNullOrWhiteSpace(guardian_f_name) || string.IsNullOrWhiteSpace(guardian_l_name) || string.IsNullOrWhiteSpace(guardian_nid) || string.IsNullOrWhiteSpace(guardian_phn_num) || string.IsNullOrWhiteSpace(guardian_email) || string.IsNullOrWhiteSpace(guardian_address) || string.IsNullOrWhiteSpace(guardian_emergency_num) || string.IsNullOrWhiteSpace(guardian_profession))
            {
                MessageBox.Show("Please enter all informations.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //string connectionString = "data source=YASSER\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
            string query1 = "INSERT INTO guardian_table ( guardian_password,guardian_f_name, guardian_l_name,guardian_nid, guardian_phn_num, guardian_email, guardian_address,guardian_emergency_num,guardian_profession) VALUES (@guardian_password, @guardian_f_name, @guardian_l_name, @guardian_nid, @guardian_phn_num, @guardian_email, @guardian_address, @guardian_emergency_num, @guardian_profession)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@guardian_password", guardian_password);
                    command.Parameters.AddWithValue("@guardian_f_name", guardian_f_name);
                    command.Parameters.AddWithValue("@guardian_l_name", guardian_l_name);
                    command.Parameters.AddWithValue("@guardian_nid", guardian_nid);
                    command.Parameters.AddWithValue("@guardian_phn_num", guardian_phn_num);
                    command.Parameters.AddWithValue("@guardian_email", guardian_email);
                    command.Parameters.AddWithValue("@guardian_address", guardian_address);
                    command.Parameters.AddWithValue("@guardian_emergency_num", guardian_emergency_num);
                    command.Parameters.AddWithValue("@guardian_profession", guardian_profession);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Failed to create the profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
            }

            ///////////////// find id from database
            string query = "SELECT guardian_id FROM guardian_table WHERE guardian_f_name = @guardian_f_name AND guardian_l_name = @guardian_l_name AND guardian_nid= @guardian_nid AND guardian_phn_num = @guardian_phn_num AND guardian_email = @guardian_email AND guardian_address = @guardian_address AND guardian_emergency_num = @guardian_emergency_num AND guardian_profession = @guardian_profession AND guardian_password = @guardian_password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_f_name", guardian_f_name);
                    command.Parameters.AddWithValue("@guardian_l_name", guardian_l_name);
                    command.Parameters.AddWithValue("guardian_nid", guardian_nid);
                    command.Parameters.AddWithValue("@guardian_phn_num", guardian_phn_num);
                    command.Parameters.AddWithValue("@guardian_email", guardian_email);
                    command.Parameters.AddWithValue("@guardian_address", guardian_address);
                    command.Parameters.AddWithValue("@guardian_emergency_num", guardian_emergency_num);
                    command.Parameters.AddWithValue("@guardian_profession", guardian_profession);
                    command.Parameters.AddWithValue("@guardian_password", guardian_password);
                   
                    object result = command.ExecuteScalar();
                    string user_id = result.ToString();
                    
                    MessageBox.Show("ID: "+ user_id, "REMEMBER your ID and Pass for farther login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                    guardian_login Guardian_Login = new guardian_login();
                    Guardian_Login.Show();
                    this.Hide();
                }
            }








        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
