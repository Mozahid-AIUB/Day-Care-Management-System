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
    public partial class bkash : Form
    {
        int id, taka,child_id,page;
        string connectionString = "data source=MOZAHID\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
        public bkash()
        {
            InitializeComponent();
        }
        public bkash(int i, int tk, int ci, int pa)
        {
            
            this.id = i;
            this.taka = tk;
            this.child_id = ci;
            this.page = pa;
            InitializeComponent();
        }

        private void button_back_to_payment_Click(object sender, EventArgs e)
        {
            payment1 gg = new payment1(id, taka, 0, child_id);
            gg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bkash_num=textBox1.Text.Trim();
            string bkash_pass=textBox2.Text.Trim();

            bool flag = true;

            if(bkash_num.Length != 11) { flag = false; }
            else if (bkash_num[0] != '0') {  flag = false; }
            else if (bkash_num[1] != '1') { flag = false; }
            else
            {
                for (int i = 2; i < 11; i++)
                {
                    if ((bkash_num[i]<'0') || (bkash_num[i]>'9') ) {  flag = false; }
                }
            }
            if (bkash_pass.Length != 5) {  flag = false; }
            if (!flag) {
                MessageBox.Show("Invalid Id or Pass.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sec ="";
                /////////////////database update
                if(page==1 || page==2 || page == 3)
                {
                    if (page == 1)
                    {
                        sec = "Nursery";
                    }
                    else if(page==2)
                    {
                        sec = "Toddler";
                    }
                    else
                    {
                        sec = "PreSchool";
                    }
                    string query = "UPDATE child_table SET child_section_grp = @child_section_grp WHERE child_id = @child_id";
                    int cnt = 0;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@child_id", child_id);
                            command.Parameters.AddWithValue("@child_section_grp", sec);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            cnt += rowsAffected;
                        }
                    }
                }

                ////////////////
                MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guardian_home guardian_Home = new guardian_home(id);
                guardian_Home.Show();
                this.Hide();
            }

        }

        private void bkash_Load(object sender, EventArgs e)
        {

        }
    }
}
