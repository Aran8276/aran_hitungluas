﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aran_hitungluas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bHitung_Click(object sender, EventArgs e)
        {
            int panjang = int.Parse(tPanjang.Text);
            int lebar = int.Parse(tLebar.Text);
            int luasPersegiPanjang = panjang * lebar;

            label5.Text = luasPersegiPanjang.ToString();
        }
    }
}
