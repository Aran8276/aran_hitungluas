using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bHitung_Click(object sender, EventArgs e)
        {
            int sisi = int.Parse(tSisi.Text);
            int luasPersegi = sisi * sisi;

            label4.Text = luasPersegi.ToString();
        }
    }
}
