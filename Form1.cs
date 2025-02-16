using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar=0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, çay,toplam;
            misir = Convert.ToInt16(txtMisir.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            su = Convert.ToInt16(txtSu.Text);
            çay = Convert.ToInt16(txtCay.Text);
            toplam = misir * 50 + çay * 20 + su * 10 + bilet * 150;
            lblToplam.Text = toplam.ToString() + " Tl";

            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + " Tl";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            txtMisir.Text = "";
            txtSu.Text = "";
            txtMisir.Focus();
        }
    }
}
