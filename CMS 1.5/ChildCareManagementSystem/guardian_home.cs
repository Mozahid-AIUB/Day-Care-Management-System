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
    public partial class guardian_home : Form
    {
        int id;
        int child_id=0;
        string connectionString = "data source=MOZAHID\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
        public guardian_home()
        {
            InitializeComponent();
        }
        public guardian_home(int i)
        {
            this.id = i;
            InitializeComponent();
            
            string query_1 = "SELECT COUNT(*) FROM child_table WHERE child_guardian_id = @child_guardian_id";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query_1, connection))
                {
                    command.Parameters.AddWithValue("@child_guardian_id", id);
                    

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        set_child_id();
                    }
                }
            }


        }
        public void set_child_id()
        {
            string query = "SELECT child_id  FROM child_table WHERE child_guardian_id = @child_guardian_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@child_guardian_id", id.ToString());
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string zzz = reader["child_id"].ToString();
                        child_id=int.Parse(zzz);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_back_to_login_Click(object sender, EventArgs e)
        {
            guardian_login l1 = new guardian_login();
            l1.Show();
            this.Hide();
        }

        private void button_show_profile_Click(object sender, EventArgs e)
        {
            showUpdateProfile sp1 = new showUpdateProfile(id);
            sp1.Show();
            this.Hide();
        }

        private void button_nursery_Click(object sender, EventArgs e)
        {
            if (child_id != 0)
            {
                nursery n1 = new nursery(id,child_id);
                n1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please first fill child informations", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_toddlers_Click(object sender, EventArgs e)
        {
           
            if (child_id != 0)
            {
                toddlers t1 = new toddlers(id, child_id);
                t1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please first fill child informations", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_pre_school_Click(object sender, EventArgs e)
        {
            if (child_id != 0)
            {
                pre_school t1 = new pre_school(id, child_id);
                t1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please first fill child informations", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_toystore_Click(object sender, EventArgs e)
        {
            if (child_id != 0)
            {
                toy_store t1 = new toy_store(id, child_id);
                t1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please first fill child informations", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Child_Update_Profile gg = new Child_Update_Profile(id,child_id);
            gg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guardian_home_Load(object sender, EventArgs e)
        {

        }
    }
}
