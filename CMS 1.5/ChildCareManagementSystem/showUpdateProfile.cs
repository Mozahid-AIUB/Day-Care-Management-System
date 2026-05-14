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
using System.Windows.Input;

namespace ChildCareManagementSystem
{
    public partial class showUpdateProfile : Form
    {
        int id;
        string connectionString = "data source=YASSER\\SQLEXPRESS; database=ChildCareDB; integrated security=SSPI";

        public showUpdateProfile()
        {
            InitializeComponent();
        }
        public showUpdateProfile(int i)
        {
            this.id = i;
            InitializeComponent();
            show_id__();
        }

        private void show_id__()
        {
            label12.Text = id.ToString();
            string userId=id.ToString();
            //f_name
            string query = "SELECT guardian_f_name FROM guardian_table WHERE guardian_id = @guardian_id"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label13.Text = zzz;
                }
            }
            //l_name
            query = "SELECT guardian_l_name FROM guardian_table WHERE guardian_id = @guardian_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label14.Text = zzz;
                }
            }

            //nid
            query = "SELECT guardian_nid FROM guardian_table WHERE guardian_id = @guardian_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label15.Text = zzz;
                }
            }

            //phn
            query = "SELECT guardian_phn_num FROM guardian_table WHERE guardian_id = @guardian_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label16.Text = zzz;
                }
            }

            //email
            query = "SELECT guardian_email FROM guardian_table WHERE guardian_id = @guardian_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label17.Text = zzz;
                }
            }
            //addres
            query = "SELECT guardian_address FROM guardian_table WHERE guardian_id = @guardian_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label18.Text = zzz;
                }
            }
            //enum
            query = "SELECT guardian_emergency_num FROM guardian_table WHERE guardian_id = @guardian_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label19.Text = zzz;
                }
            }
            //enum
            query = "SELECT guardian_profession FROM guardian_table WHERE guardian_id = @guardian_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label20.Text = zzz;
                }
            }
            //pass
            query = "SELECT guardian_password FROM guardian_table WHERE guardian_id = @guardian_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_id", userId);
                    object result = command.ExecuteScalar();
                    string zzz = result.ToString();
                    label21.Text = zzz;
                }
            }
        }
          

        private void showUpdateProfile_Load(object sender, EventArgs e)
        {

        }

        private void button_back_to_ghome_Click(object sender, EventArgs e)
        {
            guardian_home gh2 = new guardian_home(id);
            gh2.Show();
            this.Hide();
        }

        private void LoadDetails()
        {
            string query = "SELECT guardian_id, guardian_password,guardian_f_name, guardian_l_name, guardian_nid, guardian_phn_num, guardian_email, guardian_address, guardian_emergency_num, guardian_profession  FROM guardian_table WHERE guardian_id = @guardian_id";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@guardian_id", id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate the text boxes with the retrieved data
                        //textBox1_id.Text = reader["guardian_id"].ToString();
                        textBox8_npass.Text = reader["guardian_password"].ToString();
                        textBox1_nf_name.Text = reader["guardian_f_name"].ToString();
                        textBox2_nl_name.Text = reader["guardian_l_name"].ToString();
                        textBox3_nnid.Text = reader["guardian_nid"].ToString();
                        textBox4_ncontact.Text = reader["guardian_phn_num"].ToString();
                        textBox5_nemail.Text = reader["guardian_email"].ToString();
                        richTextBox1_naddress.Text = reader["guardian_address"].ToString();
                        textBox6_nemer_contact.Text = reader["guardian_emergency_num"].ToString();
                        textBox7_nprofession.Text = reader["guardian_profession"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       // Close(); // Close the form if no data is found
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //string ID = textBox1_id.Text.Trim();
            string new_f_name = textBox1_nf_name.Text.Trim();
            string new_l_name = textBox2_nl_name.Text.Trim();
            string new_nid = textBox3_nnid.Text.Trim();
            string new_phn_num = textBox4_ncontact.Text.Trim();
            string new_email = textBox5_nemail.Text.Trim();
            string new_address = richTextBox1_naddress.Text.Trim();
            string new_emergency_num = textBox6_nemer_contact.Text.Trim();
            string new_profession = textBox7_nprofession.Text.Trim();
            string new_password = textBox8_npass.Text.Trim();

            if (string.IsNullOrWhiteSpace(new_f_name) && string.IsNullOrWhiteSpace(new_l_name) && string.IsNullOrWhiteSpace(new_nid) && string.IsNullOrWhiteSpace(new_phn_num) && string.IsNullOrWhiteSpace(new_email) && string.IsNullOrWhiteSpace(new_address) && string.IsNullOrWhiteSpace(new_emergency_num) && string.IsNullOrWhiteSpace(new_profession) && string.IsNullOrWhiteSpace(new_password))
            {
                MessageBox.Show("Fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int cnt = 0;

            if (!string.IsNullOrWhiteSpace(new_f_name))
            {
                string query = "UPDATE guardian_table SET guardian_f_name = @guardian_f_name WHERE guardian_id = @guardian_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@guardian_id", id);
                        command.Parameters.AddWithValue("@guardian_f_name", new_f_name);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        cnt += rowsAffected;
                    }
                }
            }
            if (!string.IsNullOrWhiteSpace(new_l_name))
            {
                string query = "UPDATE guardian_table SET guardian_l_name = @guardian_l_name WHERE guardian_id = @guardian_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@guardian_id", id);
                        command.Parameters.AddWithValue("@guardian_l_name", new_l_name);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        cnt += rowsAffected;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(new_nid))
            {
                string query = "UPDATE guardian_table SET guardian_nid= @guardian_nid WHERE guardian_id = @guardian_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@guardian_id", id);
                        command.Parameters.AddWithValue("guardian_nid", new_nid);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        cnt += rowsAffected;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(new_phn_num))
            {
                string query = "UPDATE guardian_table SET guardian_phn_num = @guardian_phn_num WHERE guardian_id = @guardian_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@guardian_id", id);
                        command.Parameters.AddWithValue("@guardian_phn_num", new_phn_num);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        cnt += rowsAffected;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(new_email))
            {
                string query = "UPDATE guardian_table SET guardian_email = @guardian_email WHERE guardian_id = @guardian_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@guardian_id", id);
                        command.Parameters.AddWithValue("@guardian_email", new_email);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        cnt += rowsAffected;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(new_address))
            {
                string query = "UPDATE guardian_table SET guardian_address = @guardian_address WHERE guardian_id = @guardian_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@guardian_id", id);
                        command.Parameters.AddWithValue("@guardian_address", new_address);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        cnt += rowsAffected;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(new_emergency_num))
            {
                string query = "UPDATE guardian_table SET guardian_emergency_num = @guardian_emergency_num WHERE guardian_id = @guardian_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@guardian_id", id);
                        command.Parameters.AddWithValue("@guardian_emergency_num", new_emergency_num);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        cnt += rowsAffected;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(new_profession))
            {
                string query = "UPDATE guardian_table SET guardian_profession = @guardian_profession WHERE guardian_id = @guardian_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@guardian_id", id);
                        command.Parameters.AddWithValue("@guardian_profession", new_profession);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        cnt += rowsAffected;
                    }
                }
            }
            if (!string.IsNullOrWhiteSpace(new_password))
            {
                string query = "UPDATE guardian_table SET guardian_password = @guardian_password WHERE guardian_id = @guardian_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@guardian_id", id);
                        command.Parameters.AddWithValue("@guardian_password", new_password);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        cnt += rowsAffected;
                    }
                }
            }
            if (cnt > 0)
            {
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showUpdateProfile ahha = new showUpdateProfile(id);
                ahha.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No record was updated. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_naddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
