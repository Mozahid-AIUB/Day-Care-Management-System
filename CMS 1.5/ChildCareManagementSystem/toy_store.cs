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
    public partial class toy_store : Form
    {
        int id;
        int child_id;
        int tk = 0;
        public toy_store()
        {
            InitializeComponent();
        }
        public toy_store(int i,int ci)
        {
            this.id = i;
            this.child_id = ci;
            InitializeComponent();
        }
        public toy_store(int i, int ci, int tk)
        {
            this.id = i;
            this.child_id = ci;
            this.tk = tk;
            string aaa=tk.ToString();
            string bbb=(tk/100).ToString();
            InitializeComponent();
            textBox3.Text = bbb;
            textBox6.Text = aaa;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_back_to_home_Click(object sender, EventArgs e)
        {
            guardian_home g2 = new guardian_home(id);
            g2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (tk == 0) {
                MessageBox.Show("Please select items you want to perchuase", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            MessageBox.Show("Payable: "+tk, "Total Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
            payment1 pp = new payment1(id, tk, 4, child_id);
            this.Hide();
            pp.Show();


        }

        private void toy_store_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
                    }

        private void button27_Click(object sender, EventArgs e)
        {
            tk += 100;
            toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            tk += 100;
            toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tk += 100;
            toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tk += 100; 
            toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tk += 100;
            toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tk += 100;
            toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tk += 100; toy_store pppp = new toy_store(id, child_id, tk);
            this.Hide();
            pppp.Show();
        }

        private void Girls_Click(object sender, EventArgs e)
        {

        }
    }
}
