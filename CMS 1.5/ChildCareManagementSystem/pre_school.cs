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
    public partial class pre_school : Form
    {
        int id;
        int child_id;
        int taka = 0;
        public pre_school()
        {
            InitializeComponent();
        }
        public pre_school(int i, int child_id)
        {
            this.id = i;
            InitializeComponent();
            this.child_id = child_id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            guardian_home g2 = new guardian_home(id);
            g2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (taka != 0)
            {
                MessageBox.Show("Go to payment!!!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                payment1 pp = new payment1(id, taka, 3, child_id);
                this.Hide();
                pp.Show();
            }
            else
            {
                MessageBox.Show("Please choose a package", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            taka = 800;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            taka = 5200;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            taka = 20000;
        }

        private void pre_school_Load(object sender, EventArgs e)
        {

        }
    }
}
