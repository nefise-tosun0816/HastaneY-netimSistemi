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
    public partial class DoktorAnaSayfa : Form
    {
        public DoktorAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorGirişSayfası doktorGirişSayfası = new DoktorGirişSayfası();
            doktorGirişSayfası.Show();
            this.Hide();    
        }

        private void DoktorAnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
