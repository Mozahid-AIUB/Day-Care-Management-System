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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChildCareManagementSystem
{
    public partial class applicant : Form
    {
        string gender;
        string connectionString = "data source=MOZAHID\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
        public applicant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staff sta = new staff();
            sta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a_f_name=textBox_sf_name.Text.Trim();
            string a_l_name=textBox2_sl_name.Text.Trim();
            string nid=textBox3_nid.Text.Trim();
            string dob=dateTimePicker1.Text.Trim();
            string phn=textBox4_phn_num.Text.Trim();
            string email=textBox5_semail.Text.Trim();
            string cv= textBox6_scv.Text.Trim();


            string query1 = "INSERT INTO applicant_table (applicant_f_name, applicant_l_name ,applicant_nid, applicant_dob, applicant_gender, applicant_phn_num,applicant_email,applicant_cv_link) " +
                "VALUES (@applicant_f_name, @applicant_l_name, @applicant_nid, @applicant_dob, @applicant_gender, @applicant_phn_num, @applicant_email, @applicant_cv_link)";


            if (string.IsNullOrWhiteSpace(a_f_name) || string.IsNullOrWhiteSpace(a_l_name) || string.IsNullOrWhiteSpace(nid) || string.IsNullOrWhiteSpace(dob) || string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(phn) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(cv))
            {
                MessageBox.Show("Please fill all boxes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@applicant_f_name", a_f_name);
                    command.Parameters.AddWithValue("@applicant_l_name", a_l_name);
                    command.Parameters.AddWithValue("@applicant_nid", nid);
                    command.Parameters.AddWithValue("@applicant_dob", dob);
                    command.Parameters.AddWithValue("@applicant_gender", gender);
                    command.Parameters.AddWithValue("@applicant_phn_num", phn);
                    command.Parameters.AddWithValue("@applicant_email", email);
                    command.Parameters.AddWithValue("@applicant_cv_link", cv);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thanks For the application!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        applicant asc= new applicant();
                        asc.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
            }



        }

        private void textBox5_semail_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender= "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender= "Female";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
