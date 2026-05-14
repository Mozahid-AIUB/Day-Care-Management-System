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
    public partial class toddlers : Form
    {
        int id;
        int child_id;
        int taka = 0;
        public toddlers()
        {
            InitializeComponent();
        }
        public toddlers(int i,int ci)
        {
            //this.taka = tk;
            this.id = i;  
            this.child_id = ci;
            InitializeComponent();
        }

        private void toddlers_Load(object sender, EventArgs e)
        {

        }

        private void button_back_home_Click(object sender, EventArgs e)
        {
            guardian_home g2 = new guardian_home(id);
            g2.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            taka = 750;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            taka = 5600;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            taka = 19000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (taka != 0)
            {
                MessageBox.Show("Go to payment!!!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                payment1 pp = new payment1(id, taka,2, child_id);
                this.Hide();
                pp.Show();
            }
            else
            {
                MessageBox.Show("Please choose a package", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
