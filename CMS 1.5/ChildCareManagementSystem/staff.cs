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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home_Page hm= new Home_Page();
            hm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            applicant Applicant = new applicant();
            Applicant.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff_Login sl= new Staff_Login();
            sl.Show();
            this.Hide();
        }
    }
}
