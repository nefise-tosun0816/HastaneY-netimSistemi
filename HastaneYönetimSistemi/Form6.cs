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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " "; // varsayılan değer olarak boşluk atanır
            dateTimePicker1.ShowCheckBox = true; // onay kutusunu göster
            dateTimePicker1.Checked = false; // varsayılan olarak işaretlenmemiş
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
