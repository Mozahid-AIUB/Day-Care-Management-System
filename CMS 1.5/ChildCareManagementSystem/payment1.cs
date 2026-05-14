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
    public partial class payment1 : Form
    {
        int id;
        int taka;
        int child_id;
        int pay = 0;
        int page;
        public payment1()
        {
            InitializeComponent();
        }
        public payment1(int i,int tk, int page, int child_id)
        {
            this.id = i;
            this.taka = tk;
            InitializeComponent();
            label3.Text = tk.ToString() + " Taka";
            this.page = page;
            this.child_id = child_id;
        }

        private void payment1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pay == 0)
            {
                bkash Bkash = new bkash(id,taka,child_id, page);
                this.Hide();
                Bkash.Show();
            }
            else
            {
                card Card = new card(id,taka,child_id, page);
                this.Hide();
                Card.Show();
            }
        }

        private void radioButton_bkash_CheckedChanged(object sender, EventArgs e)
        {
            pay = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pay = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (page == 1) { 
                nursery gg = new nursery(id, child_id);
                gg.Show();
                this.Hide();
            }
            else if (page == 2)
            {
                toddlers gg = new toddlers(id, child_id);
                gg.Show();
                this.Hide();
            }
            else if (page == 3)
            {
                pre_school gg = new pre_school(id, child_id);
                gg.Show();
                this.Hide();
            }
            else if (page == 4)
            {
                toy_store gg = new toy_store(id, child_id);
                gg.Show();
                this.Hide();
            }
            else
            {
                guardian_home gg = new guardian_home(id);
                gg.Show();
                this.Hide();
            }
        }
    }
}
