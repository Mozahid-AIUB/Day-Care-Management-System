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
    public partial class staff_child : Form
    {
        int staff_id;
        string connectionString = "data source=YASSER\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
        public staff_child()
        {
            InitializeComponent();
        }

        public staff_child(int si)
        {
            this.staff_id = si;
            string sssssss=si.ToString();
            InitializeComponent();
            string query1 = "SELECT * FROM child_table WHERE child_assign_staff_id = "+sssssss;
            FillDataGridView1(query1);
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
        private void staff_child_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            staff_home  aaa = new staff_home(staff_id);
            this.Hide();
            aaa.Show();
        }
    }
}
