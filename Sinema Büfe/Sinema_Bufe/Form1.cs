using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasa_tutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int su, cay, misir, bilet, toplam;

            su = Convert.ToInt32(TxtSu.Text);

            cay = Convert.ToInt32(TxtCay.Text);

            misir = Convert.ToInt32(TxtMisir.Text);

            bilet = Convert.ToInt32(TxtBilet.Text);

            toplam = su * 3 + cay * 6 + misir * 12 + bilet * 24;

            LblToplam.Text = toplam.ToString() + " ₺";

            kasa_tutar = kasa_tutar + toplam;

            LblKasa.Text = kasa_tutar.ToString() + " ₺";
        }
    }
}
