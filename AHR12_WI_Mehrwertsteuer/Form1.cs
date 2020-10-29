using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHR12_WI_Mehrwertsteuer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            double bruttobetrag19 = Convert.ToDouble(txtBruttobetrag19.Text), mwstbetrag19 = 0.0, nettobetrag19 = 0.0, bruttobetrag16 = Convert.ToDouble(txtBruttobetrag16.Text), mwstbetrag16 = 0.0;
            string artikel = txtArtikel.Text, ausgabe = "";

            mwstbetrag19 = bruttobetrag19 / 119 * 19;
            nettobetrag19 = bruttobetrag19 / 119 * 100;
            mwstbetrag16 = bruttobetrag16 / 116 * 16;
            ausgabe = "Der Netto Preis für den Artikel " + artikel + " beträgt " + Math.Round(nettobetrag19) + "EUR." + "\n" + "\n" + "Der neue Bruttobetrag mit 16% MwSt beträgt " + bruttobetrag16 + "EUR." ;


            txtMwStBetrag19.Text = Convert.ToString(Math.Round(mwstbetrag19,2));
            txtNettobetrag.Text = Convert.ToString(Math.Round(nettobetrag19,2));
            txtMwStBetrag16.Text = Convert.ToString(Math.Round(mwstbetrag16,2));
            rtbAusgabe.Text = ausgabe;     
        }
    }
}
