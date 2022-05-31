using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarinakTakip
{
    public partial class HayvanDetay : Form
    {
        int BarinakId;
        string BarinakAd;
        public HayvanDetay(int barinakId, int hayvanId, string barinakAd, string hayvanAd, string hayvanTur, string hayvanCins, string hayvanSaglik, string hayvanYas )
        {
            InitializeComponent();
            txtAd.Text = hayvanAd;
            txtTur.Text = hayvanTur;
            txtCins.Text = hayvanCins;
            txtSaglik.Text = hayvanSaglik;
            txtYas.Text = hayvanYas;
            txtBarinakAdi.Text = barinakAd + "'NA KAYITLI";
            BarinakId = barinakId;
            BarinakAd = barinakAd;

        }

        private void picGeri_Click(object sender, EventArgs e)
        {
            HayvanlariListele hayvanlariListele = new HayvanlariListele(BarinakId,BarinakAd );
            hayvanlariListele.Show();
            this.Hide();
        }

        private void HayvanDetay_Load(object sender, EventArgs e)
        {
            this.Text = txtAd.Text + " Detay";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
    }
}
