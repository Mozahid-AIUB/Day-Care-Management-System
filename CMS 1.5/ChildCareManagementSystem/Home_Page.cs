using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildCareManagementSystem
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staff_login_button_Click(object sender, EventArgs e)
        {
            staff Staff = new staff();
            Staff.Show();
            this.Hide();

        }

        private void admin_login_button_Click(object sender, EventArgs e)
        {
            Admin_Login_Page admin_login= new Admin_Login_Page();
            admin_login.Show();
            this.Hide();
        }

        private void parent_login_button_Click(object sender, EventArgs e)
        {
            guardian_login gg = new guardian_login();
            gg.Show();
            this.Hide();
        }
    }
}
