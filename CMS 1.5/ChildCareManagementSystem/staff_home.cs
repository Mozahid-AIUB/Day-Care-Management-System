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
    public partial class staff_home : Form
    {
        int staff_id;
        public staff_home()
        {
            InitializeComponent();
        }
        public staff_home(int id)
        {
            this.staff_id = id;
            InitializeComponent();
        }

        private void staff_home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff_Login sas=new Staff_Login();
            sas.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff_show aaaa=new Staff_show(staff_id);
            this.Hide();
            aaaa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staff_child staff_Child = new staff_child(staff_id);
            this.Hide();
            staff_Child.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            staff_child staff_Child = new staff_child(staff_id);
            this.Hide();
            staff_Child.Show();
        }
    }
}
