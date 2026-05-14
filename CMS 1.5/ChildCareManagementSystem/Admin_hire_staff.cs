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
    public partial class Admin_hire_staff : Form
    {

        string s1, s2;
        string staff_job_title;
        string connectionString = "data source=MOZAHID\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
        public Admin_hire_staff()
        {
            InitializeComponent();

        }
        public Admin_hire_staff(string ss1, string ss2)
        {
            this.s1=ss1;
            this.s2=ss2;
            InitializeComponent();
            string query = "SELECT * FROM applicant_table";
            FillDataGridView1(query);

        }
       



        private void FillDataGridView1(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Admin_Profile_Page dgdf = new Admin_Profile_Page(s1,s2);
            dgdf.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            staff_job_title = "Nursery";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            staff_job_title = "Toddler";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            staff_job_title = "PreSchool";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string applicant_id=applicant_id_textBox1.Text.Trim();
            string query = "DELETE FROM applicant_table WHERE applicant_id = @applicant_id";
            if (!string.IsNullOrEmpty(applicant_id)){
                int ok;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@applicant_id", applicant_id);
                        connection.Open();
                        ok = command.ExecuteNonQuery();
                    }
                }
                if (ok > 0)
                {
                    MessageBox.Show("Applicant Rejected", "Reject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin_hire_staff fdgkldfn= new Admin_hire_staff(s1,s2);
                    fdgkldfn.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ID not found", "No Reject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void admin_username_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_accept_Click(object sender, EventArgs e)
        {
            string applicant_id = applicant_id_textBox1.Text.Trim();
            if (string.IsNullOrEmpty(applicant_id))
            {
                return;
            }
            string query = "SELECT COUNT(*) FROM applicant_table WHERE applicant_id = @applicant_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@applicant_id", applicant_id);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Enter Valid ID", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            string f_name, l_name, nid, dob, gender, phn, email;
            query = "SELECT applicant_f_name FROM applicant_table WHERE applicant_id = @applicant_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@applicant_id", applicant_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    f_name = zzz;
                }
            }

            query = "SELECT applicant_l_name FROM applicant_table WHERE applicant_id = @applicant_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@applicant_id", applicant_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    l_name = zzz;
                }
            }

            query = "SELECT applicant_nid FROM applicant_table WHERE applicant_id = @applicant_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@applicant_id", applicant_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    nid = zzz;
                }
            }

            query = "SELECT applicant_dob FROM applicant_table WHERE applicant_id = @applicant_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@applicant_id", applicant_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    dob = zzz;
                }
            }

            query = "SELECT applicant_gender FROM applicant_table WHERE applicant_id = @applicant_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@applicant_id", applicant_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    gender = zzz;
                }
            }

            query = "SELECT applicant_phn_num FROM applicant_table WHERE applicant_id = @applicant_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@applicant_id", applicant_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    phn = zzz;
                }
            }

            query = "SELECT applicant_email FROM applicant_table WHERE applicant_id = @applicant_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@applicant_id", applicant_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    email = zzz;
                }
            }

            query = "DELETE FROM applicant_table WHERE applicant_id = @applicant_id";
            if (!string.IsNullOrEmpty(applicant_id))
            {
                int ok;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@applicant_id", applicant_id);
                        connection.Open();
                        ok = command.ExecuteNonQuery();
                    }
                }
            }
            else { return; }

            string query1 = "INSERT INTO staff_table (staff_password, staff_f_name, staff_l_name, staff_nid, staff_dob, staff_gender, staff_phn_num, staff_email, staff_job_title, staff_salary) " +
                "VALUES (@staff_password, @staff_f_name, @staff_l_name, @staff_nid, @staff_dob, @staff_gender, @staff_phn_num, @staff_email, @staff_job_title, @staff_salary)";
            string pass = "123456789";
            string salary = "20000";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@staff_password", pass);
                    command.Parameters.AddWithValue("@staff_f_name", f_name);
                    command.Parameters.AddWithValue("@staff_l_name", l_name);
                    command.Parameters.AddWithValue("@staff_nid", nid);
                    command.Parameters.AddWithValue("@staff_dob", dob);
                    command.Parameters.AddWithValue("@staff_gender", gender);
                    command.Parameters.AddWithValue("@staff_phn_num", phn);
                    command.Parameters.AddWithValue("@staff_email", email);
                    command.Parameters.AddWithValue("@staff_job_title", staff_job_title);
                    command.Parameters.AddWithValue("@staff_salary", salary);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Applicant Accepted", "Accept", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Admin_hire_staff fdgkldfn = new Admin_hire_staff(s1, s2);
                        fdgkldfn.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void Admin_hire_staff_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
