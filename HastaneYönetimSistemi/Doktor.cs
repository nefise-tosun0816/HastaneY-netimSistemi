using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HastaneYönetimSistemi.DoktorSınıfı;

namespace HastaneYönetimSistemi
{
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Doktor_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(Branslar)));
        }

        private void richTextBox1_VisibleChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Arama...";
            richTextBox1.ForeColor = Color.Gray;
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
         
            if (richTextBox1.Text == "Arama...")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.Black; // Yazı rengini siyah olarak ayarla
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                richTextBox1.Text = "Arama...";
                richTextBox1.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelKayıt personelKayıt = new PersonelKayıt();
            personelKayıt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add("Kullanıcı sisteme başarıyla eklendi");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add("Kullanıcı sistemden silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add("Kullanıcı güncellendi");
        }
    }
}
