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
    public partial class assign_staff : Form
    {
        string s1, s2;
        string connectionString = "data source=MOZAHID\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";

        public assign_staff()
        {
            InitializeComponent();
        }
        public assign_staff(string ss1, string ss2)
        {
            InitializeComponent();
            this.s1 = ss1;
            this.s2 = ss2;
            string query1 = "SELECT * FROM staff_table";
            string query2 = "SELECT * FROM child_table WHERE child_assign_staff_id IS NULL";
            FillDataGridView1(query1);
            FillDataGridView2(query2);

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


        private void button1_Click(object sender, EventArgs e)
        {
            string staff_id= textBox1.Text.Trim();
            string child_id = textBox2.Text.Trim();
            if (string.IsNullOrWhiteSpace(staff_id) || string.IsNullOrWhiteSpace(child_id))
            {
                MessageBox.Show("Fill both Boxes", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "UPDATE child_table SET child_assign_staff_id= @child_assign_staff_id WHERE child_id = @child_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@child_id", child_id);
                    command.Parameters.AddWithValue("child_assign_staff_id", staff_id);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
            assign_staff aaaa= new assign_staff(s1,s2);
            aaaa.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Profile_Page assd= new Admin_Profile_Page(s1,s2);
            assd.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void assign_staff_Load(object sender, EventArgs e)
        {

        }
    }
}
