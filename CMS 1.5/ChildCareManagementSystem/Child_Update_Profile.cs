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
    public partial class Child_Update_Profile : Form
    {
        int id;
        int child_id = 0;
        string connectionString = "data source=MOZAHID\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";
        string gender = "Male";
        public Child_Update_Profile()
        {

            InitializeComponent();
        }
        public Child_Update_Profile(int id, int child_id)
        {
            InitializeComponent();
            this.id = id;
            this.child_id = child_id;
            string z = "";
            label11.Text = z;
            label12.Text = z;
            label13.Text = z;
            label14.Text = z;
            label15.Text = z;
            label16.Text = z;
            if (child_id != 0)
            {
                show_info();
            }

        }
        public void show_info()
        {
            string query = "SELECT child_f_name FROM child_table WHERE child_id = @child_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@child_id", child_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label11.Text = zzz;
                }
            }

            query = "SELECT child_l_name FROM child_table WHERE child_id = @child_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@child_id", child_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label12.Text = zzz;
                }
            }

            query = "SELECT child_dob FROM child_table WHERE child_id = @child_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@child_id", child_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label13.Text = zzz;
                }
            }

            query = "SELECT child_gender FROM child_table WHERE child_id = @child_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@child_id", child_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label14.Text = zzz;
                }
            }

            query = "SELECT child_blood_grp FROM child_table WHERE child_id = @child_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@child_id", child_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label15.Text = zzz;
                }
            }

            query = "SELECT child_health_info FROM child_table WHERE child_id = @child_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@child_id", child_id);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label16.Text = "NULL";
                    if (zzz.Length != 0)
                    {
                        label16.Text = zzz;
                    }
                }
            }



        }

        private void comboBox_child_bg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardian_home hm = new guardian_home(id);
            hm.Show();
            this.Hide();
        }

        private void textBox_child_l_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_child_f_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_healthissue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string f_name= textBox_child_f_name.Text.Trim();
            string l_name=textBox_child_l_name.Text.Trim();
            string dob = textBox_child_dob.Text.Trim();
            string blood=textBox1_bg.Text.Trim();
            string health = richTextBox_healthissue.Text.Trim();
            


            if (child_id == 0)
            {
                string query1 = "INSERT INTO child_table (child_f_name, child_l_name, child_dob, child_gender, child_blood_grp, child_guardian_id) " +
                    "VALUES (@child_f_name, @child_l_name, @child_dob, @child_gender, @child_blood_grp, @child_guardian_id)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@child_f_name", f_name);
                        command.Parameters.AddWithValue("@child_l_name", l_name);
                        command.Parameters.AddWithValue("@child_dob", dob);
                        command.Parameters.AddWithValue("@child_gender", gender);
                        command.Parameters.AddWithValue("@child_blood_grp", blood);
                        command.Parameters.AddWithValue("@child_guardian_id", id);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            guardian_home abc = new guardian_home(id);
                            abc.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                }
            }
            else
            {
                int cnt = 0;
                //f_name
                if (!string.IsNullOrWhiteSpace(f_name))
                {
                    string query = "UPDATE child_table SET child_f_name = @child_f_name WHERE child_id = @child_id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@child_id", child_id);
                            command.Parameters.AddWithValue("@child_f_name", f_name);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            cnt += rowsAffected;
                        }
                    }
                }

                //l_name
                if (!string.IsNullOrWhiteSpace(l_name))
                {
                    string query = "UPDATE child_table SET child_l_name = @child_l_name WHERE child_id = @child_id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@child_id", child_id);
                            command.Parameters.AddWithValue("@child_l_name", l_name);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            cnt += rowsAffected;
                        }
                    }
                }

                if (!string.IsNullOrWhiteSpace(dob))
                {
                    string query = "UPDATE child_table SET child_dob = @child_dob WHERE child_id = @child_id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@child_id", child_id);
                            command.Parameters.AddWithValue("@child_dob", dob);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            cnt += rowsAffected;
                        }
                    }
                }
                if (!string.IsNullOrWhiteSpace(gender))
                {
                    string query = "UPDATE child_table SET child_gender = @child_gender WHERE child_id = @child_id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@child_id", child_id);
                            command.Parameters.AddWithValue("@child_gender", gender);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            cnt += rowsAffected;
                        }
                    }
                }
                if (!string.IsNullOrWhiteSpace(blood))
                {
                    string query = "UPDATE child_table SET child_blood_grp = @child_blood_grp WHERE child_id = @child_id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@child_id", child_id);
                            command.Parameters.AddWithValue("@child_blood_grp", blood);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            cnt += rowsAffected;
                        }
                    }
                }

                if (!string.IsNullOrWhiteSpace(health))
                {
                    string query = "UPDATE child_table SET child_health_info = @child_health_info WHERE child_id = @child_id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@child_id", child_id);
                            command.Parameters.AddWithValue("@child_health_info", health);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            cnt += rowsAffected;
                        }
                    }
                }

                if (cnt > 0)
                {
                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Child_Update_Profile ahha = new Child_Update_Profile(id,child_id);
                    ahha.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No record was updated. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }
    }
}
