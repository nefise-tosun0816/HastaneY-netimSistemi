using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimSistemi
{
    public partial class YöneticiAnaSayfa : Form
    {
        public YöneticiAnaSayfa()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm)
        {

            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
       
            frm.Show();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            YöneticiGirişSayfası form2 = new YöneticiGirişSayfası();
            form2.Show();
            this.Close();
        }

        

        

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void YöneticiAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.FlatAppearance.BorderColor = Color.Red;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.FlatAppearance.BorderColor = Color.Red;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
           button9.FlatAppearance.BorderColor = Color.Blue;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.FlatAppearance.BorderColor = Color.Blue;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            YöneticiGirişSayfası ygs = new YöneticiGirişSayfası();
            ygs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YöneticiGirişSayfası ygs = new YöneticiGirişSayfası();
            ygs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YöneticiGirişSayfası ygs = new YöneticiGirişSayfası();
            ygs.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            YöneticiGirişSayfası ygs = new YöneticiGirişSayfası();
            ygs.Show();
            this.Hide();
        }
    }
}
