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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
       
        }
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                Form5 form5 = new Form5();
                form5.Show();
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTimePicker dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";

            // DateTimePicker'in ValueChanged olayını kullanarak tarih değiştiğinde çalışacak kod
           
                // Seçilen tarihi messagebox ile göstermek için
                MessageBox.Show(dateTimePicker1.Value.ToString("dd.MM.yyyy"));
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Checked)
            {
                // DateTimePicker kontrolünün seçili tarihini kullan
                DateTime selectedDate = dateTimePicker1.Value;
                MessageBox.Show(selectedDate.ToShortDateString());
            }
            else
            {
                // DateTimePicker kontrolü seçili değil, bir uyarı mesajı göster
                MessageBox.Show("Lütfen bir tarih seçin.");
            }
        }
    }
}
