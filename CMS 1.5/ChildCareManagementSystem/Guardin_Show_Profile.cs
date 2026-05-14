using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildCareManagementSystem
{
    public partial class Guardin_Show_Profile : Form
    {
        string s1, s2;
        string connectionString = "data source=YASSER\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
        public Guardin_Show_Profile()
        {
            InitializeComponent();
        }
        public Guardin_Show_Profile(string ss1, string ss2)
        {
            s1 = ss1;
            s2 = ss2;
            InitializeComponent();
            string query = "SELECT * FROM guardian_table";
            FillDataGridView(query);
        }
        private void FillDataGridView(string query)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guardin_Show_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
