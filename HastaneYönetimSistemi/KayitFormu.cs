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
    public partial class KayitFormu : Form
    {
        public KayitFormu()
        {
            InitializeComponent();
        }

        private void sifreTextBox_Enter(object sender, EventArgs e)
        {
            
            // TextBox nesnesi odak kazandığında, varsayılan metni kontrol edin ve gerekiyorsa silin
            if (sifreTextBox.Text == "şifrenizi yazın...")
            {
                sifreTextBox.Text = "";
                sifreTextBox.ForeColor = Color.Black; // Yazı rengini siyah olarak ayarla
            }
        }

        private void soyadTextBox_Enter(object sender, EventArgs e)
        {
            soyadTextBox.Text = "soyadınızı yazın...";
        }

        private void adTextBox_Enter(object sender, EventArgs e)
        {
            adTextBox.Text = "adınızı yazın...";
        }

        private void kayitOlButton_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTCKimlik_TextChanged(object sender, EventArgs e)
        {
            // TextBox'ta girilen değeri alın
            string tcKimlik = textBoxTCKimlik.Text;

            // Girilen değerin TC Kimlik Numarası formatına uygun olup olmadığını kontrol edin
            if (tcKimlik.Length == 11 && tcKimlik.All(char.IsDigit))
            {
                // Girilen değer TC Kimlik Numarası formatına uygun olduğunda, işlemleri yapabilirsiniz
                // Örneğin, başka bir TextBox'e geçiş yapabilirsiniz
                adTextBox.Focus();
            }
            else
            {
                // Girilen değer TC Kimlik Numarası formatına uygun değilse, kullanıcıya bir mesaj gösterin
                MessageBox.Show("Lütfen geçerli bir TC Kimlik Numarası girin.");
            }
        }

        private void sifreTextBox_Leave(object sender, EventArgs e)
        {
            // TextBox nesnesinden çıkıldığında, eğer TextBox nesnesi boş ise varsayılan metni göster
            if (string.IsNullOrWhiteSpace(sifreTextBox.Text))
            {
                sifreTextBox.Text = "şifrenizi yazın...";
                sifreTextBox.ForeColor = Color.Gray; // Yazı rengini gri olarak ayarla
            }
        }
    }
}
