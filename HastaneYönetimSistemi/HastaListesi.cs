﻿using System;
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
    public partial class HastaListesi : Form
    {
        public HastaListesi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YöneticiAnaSayfa form1= new YöneticiAnaSayfa();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastalarıGöster hastalarıgöster = new HastalarıGöster();
            hastalarıgöster.Show();
            this.Hide();
        }
    } 
}

