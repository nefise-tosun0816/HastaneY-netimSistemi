using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HastaneYönetimSistemi.HemşireSınıfı;
namespace HastaneYönetimSistemi
{
    public partial class Hemsire : Form
    {
        public Hemsire()
        {
            InitializeComponent();
        }

        private void Form7_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

       

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: yadrBu kod satırı 'hastaneDataSet4.Hemşire' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hemşireTableAdapter.Fill(this.hastaneDataSet4.Hemşire);
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(HBranslar)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
           PersonelKayıt personelKayıt = new PersonelKayıt();
            personelKayıt.Show();
            this.Hide();

        }
    }
}
