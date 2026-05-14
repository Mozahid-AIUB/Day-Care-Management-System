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
    public partial class Staff_show : Form
    {
        int staff_id;
        string connectionString = "data source=YASSER\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
        public Staff_show()
        {
            InitializeComponent();
        }
        public Staff_show(int ii)
        {
            InitializeComponent();
            this.staff_id = ii;
            show_id__();
        }

        private void show_id__()
        {
            label12.Text = staff_id.ToString();
            string userId = staff_id.ToString();
            //pass
            string query = "SELECT staff_password FROM staff_table WHERE staff_id = @staff_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@staff_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label21.Text = zzz;
                }
            }
            
            query = "SELECT staff_f_name FROM staff_table WHERE staff_id = @staff_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@staff_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label13.Text = zzz;
                }
            }

            query = "SELECT staff_l_name FROM staff_table WHERE staff_id = @staff_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@staff_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label14.Text = zzz;
                }
            }
            query = "SELECT staff_nid FROM staff_table WHERE staff_id = @staff_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@staff_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label15.Text = zzz;
                }
            }

            query = "SELECT staff_phn_num FROM staff_table WHERE staff_id = @staff_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@staff_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label16.Text = zzz;
                }
            }

            query = "SELECT staff_email FROM staff_table WHERE staff_id = @staff_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@staff_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label17.Text = zzz;
                }
            }

            query = "SELECT staff_job_title FROM staff_table WHERE staff_id = @staff_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@staff_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label19.Text = zzz;
                }
            }

            query = "SELECT staff_salary FROM staff_table WHERE staff_id = @staff_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@staff_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label20.Text = zzz;
                }
            }
        }
        ////////////////////////////////////////////////////////



        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string new_f_name = textBox1_nf_name.Text.Trim();
            string new_l_name = textBox2_nl_name.Text.Trim();
            string new_password = textBox8_npass.Text.Trim();
            string new_nid = textBox3_nnid.Text.Trim();
            string new_phn_num = textBox4_ncontact.Text.Trim();
            string new_email = textBox5_nemail.Text.Trim();
            if (string.IsNullOrWhiteSpace(new_f_name) || string.IsNullOrWhiteSpace(new_l_name) || string.IsNullOrWhiteSpace(new_nid) || string.IsNullOrWhiteSpace(new_phn_num) || string.IsNullOrWhiteSpace(new_email) || string.IsNullOrWhiteSpace(new_password))
            {
                MessageBox.Show("Fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "UPDATE staff_table SET staff_f_name = @staff_f_name, staff_l_name = @staff_l_name,  staff_password = @staff_password," +
                "staff_nid = @staff_nid, staff_phn_num= @staff_phn_num, staff_email=@staff_email WHERE staff_id = @staff_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@staff_id", staff_id);
                    command.Parameters.AddWithValue("@staff_f_name", new_f_name);
                    command.Parameters.AddWithValue("@staff_l_name", new_l_name);
                    command.Parameters.AddWithValue("@staff_password", new_password);
                    command.Parameters.AddWithValue("@staff_nid", new_nid);
                    command.Parameters.AddWithValue("@staff_phn_num", new_phn_num);
                    command.Parameters.AddWithValue("@staff_email", new_email);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Staff_show ahha = new Staff_show(staff_id);
            ahha.Show();
            this.Hide();



        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button_back_to_ghome_Click(object sender, EventArgs e)
        {
            staff_home fkgj = new staff_home(staff_id);
            this.Hide();
            fkgj.Show();
        }
    }
}
