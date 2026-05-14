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
    public partial class Admin_Profile_Page : Form
    {
        string ss1;
        string ss2;
        public Admin_Profile_Page()
        {
            InitializeComponent();
        }

        public Admin_Profile_Page(string s1, string s2)
        {
            ss1 = s1;
            ss2 = s2;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Database_Profiles gg1 = new Database_Profiles(ss1,ss2);
            gg1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_update_Click(object sender, EventArgs e)
        {
            Admin_Update_page f4 = new Admin_Update_page(ss1, ss2);
            f4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Login_Page f5 = new Admin_Login_Page();
            f5.Show();
            this.Hide();
        }

        private void children_profile_button_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void job_rq_button_Click(object sender, EventArgs e)
        {
            Admin_hire_staff ahs=new Admin_hire_staff(ss1,ss2);
            ahs.Show();
            this.Hide();
        }

        private void customer_staff_button_Click(object sender, EventArgs e)
        {
            assign_staff adsjkd = new assign_staff(ss1, ss2);
            adsjkd.Show();
            this.Hide();
        }
    }
}
