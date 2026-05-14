using System;
using System.Collections;
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
    public partial class Database_Profiles : Form
    {
        string connectionString = "data source=MOZAHID\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
        string s1;
        string s2;
        string[] sss1 = new string[] { "", "ID", "Name", "NID", "Phone", "Mail" };
        string[] sss2 = new string[] { "", "ID", "Name", "Date of Birth","Gender", "Blood Group", "Guardian ID", "Assign Staff ID" };
        string[] sss3 = new string[] { "", "ID", "Name", "NID", "Phone", "Mail", "Gender" };

        public Database_Profiles()
        {
            InitializeComponent();
        }
        public Database_Profiles(string s111, string s222)
        {
            s1 = s111;
            s2 = s222;
            
            InitializeComponent();
            
            string query1 = "SELECT * FROM guardian_table";
            string query2 = "SELECT * FROM child_table";
            string query3 = "SELECT * FROM staff_table";
            
            FillDataGridView1(query1);
            FillDataGridView2(query2);
            FillDataGridView3(query3);

            comboBox1.DataSource = sss1;
            comboBox2.DataSource = sss2;
            comboBox3.DataSource = sss3;
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

        private void FillDataGridView2(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView2.DataSource = dataTable;
                }
            }
        }

        private void FillDataGridView3(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView3.DataSource = dataTable;
                }
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_button_Click_1(object sender, EventArgs e)
        {
            string search_text = textBox22.Text.Trim();
            string search_value = comboBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(search_text))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"SELECT * FROM guardian_table
                             WHERE guardian_id LIKE @searchTerm      
                             OR guardian_password LIKE @searchTerm
                             OR guardian_f_name LIKE @searchTerm
                             OR guardian_l_name LIKE @searchTerm   
                             OR guardian_nid LIKE @searchTerm
                             OR guardian_phn_num LIKE @searchTerm
                             OR guardian_email LIKE @searchTerm
                             OR guardian_address LIKE @searchTerm
                             OR guardian_emergency_num LIKE @searchTerm
                             OR guardian_profession LIKE @searchTerm";
            if (search_value == "ID")
            {
                query = @"SELECT * FROM guardian_table WHERE guardian_id LIKE @searchTerm";
            }
            else if (search_value == "Name")
            {
                query = @"SELECT * FROM guardian_table
                    WHERE guardian_f_name LIKE @searchTerm
                    OR guardian_l_name LIKE @searchTerm";
            }
            else if (search_value == "NID")
            {
                query = @"SELECT * FROM guardian_table
                    WHERE guardian_nid LIKE @searchTerm";
            }
            else if (search_value == "Phone")
            {
                query = @"SELECT * FROM guardian_table
                    WHERE guardian_phn_num LIKE @searchTerm";
            }
            else if (search_value == "Mail")
            {
                query = @"SELECT * FROM guardian_table
                    WHERE guardian_email LIKE @searchTerm";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + search_text + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching rows found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            Database_Profiles ggg = new Database_Profiles(s1, s2);
            this.Hide();
            ggg.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Profile_Page admin_Profile_Page = new Admin_Profile_Page(s1, s2);
            admin_Profile_Page.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string search_text = textBox1.Text.Trim();
            string search_value = comboBox2.Text.Trim();
            if (string.IsNullOrWhiteSpace(search_text))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"SELECT * FROM child_table
                             WHERE child_id LIKE @searchTerm      
                             OR child_f_name LIKE @searchTerm
                             OR child_l_name LIKE @searchTerm
                             OR child_dob LIKE @searchTerm   
                             OR child_gender LIKE @searchTerm
                             OR child_blood_grp LIKE @searchTerm
                             OR child_guardian_id LIKE @searchTerm
                             OR child_assign_staff_id LIKE @searchTerm
                             OR child_section_grp LIKE @searchTerm
                             OR child_health_info LIKE @searchTerm";

            if (search_value == "ID")
            {
                query = @"SELECT * FROM child_table
                             WHERE child_id LIKE @searchTerm";
            }
            else if (search_value == "Name")
            {
                query = @"SELECT * FROM child_table
                             WHERE child_f_name LIKE @searchTerm
                             OR child_l_name LIKE @searchTerm";
            }
            else if (search_value == "Date of Birth")
            {
                query = @"SELECT * FROM child_table
                             WHERE child_dob LIKE @searchTerm";
            }
            else if (search_value == "Gender")
            {
                query = @"SELECT * FROM child_table
                             WHERE child_gender LIKE @searchTerm";
            }
            else if (search_value == "Blood Group")
            {
                query = @"SELECT * FROM child_table
                             WHERE child_blood_grp LIKE @searchTerm";
            }
            else if (search_value == "Guardian ID")
            {
                query = @"SELECT * FROM child_table
                             WHERE child_guardian_id LIKE @searchTerm";
            }
            else if (search_value == "Assign Staff ID")
            {
                query = @"SELECT * FROM child_table
                             WHERE child_assign_staff_id LIKE @searchTerm";
            }
            //"", "ID", "Name", "Date of Birth","Gender", "Blood Group", "Guardian ID", "Assign Staff ID"
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + search_text + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching rows found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Database_Profiles ggg = new Database_Profiles(s1,s2);
            this.Hide();
            ggg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Profile_Page admin_Profile_Page = new Admin_Profile_Page(s1, s2);
            admin_Profile_Page.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string search_text = textBox2.Text.Trim();
            string search_value = comboBox3.Text.Trim();
            if (string.IsNullOrWhiteSpace(search_text))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query= @"SELECT * FROM staff_table
                             WHERE staff_id LIKE @searchTerm      
                             OR staff_password LIKE @searchTerm
                             OR staff_f_name LIKE @searchTerm
                             OR staff_l_name LIKE @searchTerm   
                             OR staff_nid LIKE @searchTerm
                             OR staff_dob LIKE @searchTerm
                             OR staff_gender LIKE @searchTerm
                             OR staff_phn_num LIKE @searchTerm
                             OR staff_email LIKE @searchTerm
                             OR staff_salary LIKE @searchTerm
                             OR staff_job_title LIKE @searchTerm";

            if (search_value == "ID")
            {
                query = @"SELECT * FROM staff_table
                             WHERE staff_id LIKE @searchTerm";
            }
            else if (search_value == "Name")
            {
                query = @"SELECT * FROM staff_table
                             WHERE staff_f_name LIKE @searchTerm
                             OR staff_l_name LIKE @searchTerm";
            }
            else if (search_value == "NID")
            {
                query = @"SELECT * FROM staff_table
                             WHERE staff_nid LIKE @searchTerm";
            }
            else if (search_value == "Phone")
            {
                query = @"SELECT * FROM staff_table
                             WHERE staff_phn_num LIKE @searchTerm";
            }
            else if (search_value == "Mail")
            {
                query = @"SELECT * FROM staff_table
                             WHERE staff_email LIKE @searchTerm";
            }
            else if (search_value == "Gender")
            {
                query = @"SELECT * FROM staff_table
                             WHERE staff_gender LIKE @searchTerm";
            }
            //"ID", "Name", "NID", "Phone", "Mail", "Gender"

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + search_text + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView3.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching rows found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Database_Profiles ggg = new Database_Profiles(s1, s2);
            this.Hide();
            ggg.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_Profile_Page admin_Profile_Page = new Admin_Profile_Page(s1, s2);
            admin_Profile_Page.Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Database_Profiles_Load(object sender, EventArgs e)
        {

        }
    }
}
