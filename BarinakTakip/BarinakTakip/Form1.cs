using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarinakTakip.Models;

namespace BarinakTakip
{
    public partial class BarinakTakipSistemi : Form
    {
        ApplicationConnectionDb context = new ApplicationConnectionDb();
        public BarinakTakipSistemi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Barınak Takip Sistemi";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;


        }

        private void butonKayit_Click(object sender, EventArgs e)
        {
            KayitEkrani kayitEkrani = new KayitEkrani();
            kayitEkrani.Show();
            this.Hide();
        }

        private void butonGiris_Click(object sender, EventArgs e)
        {
            GirisEkrani g = new GirisEkrani(false);
            g.Show();
            this.Hide();

        }
    }
}
