using BarinakTakip.Models;
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
    public partial class GirisEkrani : Form
    {
        ApplicationConnectionDb context = new ApplicationConnectionDb();

        Boolean kayittanMiGeldi = false;
        public GirisEkrani(Boolean kayittanMiGeldi)
        {
            InitializeComponent();
            this.kayittanMiGeldi = kayittanMiGeldi;
        }

        int hak = 3; bool durum = false;

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

            if (kayittanMiGeldi)
            {
                MessageBox.Show("Kullanıcı oluşturuldu");
            }

            this.AcceptButton = butonGiris; this.CancelButton = butonIptal;
            GirisHakki.Text = Convert.ToString(hak);
            RadioKullanici.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void butonGiris_Click(object sender, EventArgs e)
        {

        }

        private void butonIptal_Click(object sender, EventArgs e)
        {

        }

        private void butonGiris_Click_1(object sender, EventArgs e)
        {
           var Kullanici =  context.Kullanici.Where(k => k.Mail == txtKullaniciAdi.Text && k.Parola == txtParola.Text);
              if (Kullanici.Count() == 0)
               {
                MessageBox.Show("HATALI GİRİŞ!", "YANLIŞ KOMBİNASYON!", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            else
               {
                MessageBox.Show("GİRİŞ BAŞARILI!", "DOĞRU KOMBİNASYON!", MessageBoxButtons.OK);
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
        }

        private void butonIptal_Click_1(object sender, EventArgs e)
        {
            BarinakTakipSistemi barinakTakip = new BarinakTakipSistemi();
            barinakTakip.Show();
            this.Hide();
        }
    }
}
