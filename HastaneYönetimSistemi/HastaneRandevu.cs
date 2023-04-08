using System;
using HastaneYönetimSistemi;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HastaneYönetimSistemi.RandevuBilgileriSınıfı;


namespace HastaneYönetimSistemi
{
    public partial class HastaneRandevu : Form
    {
        public HastaneRandevu()
        {
            InitializeComponent();
        }

       
        private void HastaneRandevu_Load(object sender, EventArgs e)
        {
            cmbPoliklinik.Items.AddRange(Enum.GetNames(typeof(Poliklinik)));
            dateTimePicker1.Value = DateTime.Now;
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHekim.Items.Clear();
            if (cmbPoliklinik.Text == "BEYİN_VE_SİNİR_CERRAHİSİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(B_Cerrah)));
            else if (cmbPoliklinik.Text == "KALP_DAMAR_CERRAHİSİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(Kalp_Damar)));
            else if (cmbPoliklinik.Text == "KARDİYOLOJİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(Kardiyoloji)));
            else if (cmbPoliklinik.Text == "KBB")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(KBB)));
            else if (cmbPoliklinik.Text == "NEFROLOJİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(Nefroloji)));
            else if (cmbPoliklinik.Text == "NÖROLOJİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(Nöroloji)));
            else if (cmbPoliklinik.Text == "DİYABET")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(Diyabet)));
            else if (cmbPoliklinik.Text == "ORTOPEDİ_VE_TRAVMATOLOJİ")
                cmbHekim.Items.AddRange(Enum.GetNames(typeof(ORTOPEDİ_VE_TRAVMATOLOJİ)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear(); // TextBox'ları temizle
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1; // ComboBox'ları sıfırla
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now; // DateTimePicker'ları sıfırla
                }
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RandevuGirişSayfası form2 = new RandevuGirişSayfası();
            form2.Show();
            this.Hide();
        }
    }
}
