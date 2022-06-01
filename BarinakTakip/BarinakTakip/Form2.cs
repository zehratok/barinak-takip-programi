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

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

            if (kayittanMiGeldi)
            {
                MessageBox.Show("Kullanıcı oluşturuldu");
            }
            this.Text = "Giriş Ekranı";
            this.AcceptButton = butonGiris; this.CancelButton = butonIptal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void butonGiris_Click_1(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                MessageBox.Show("Lütfen e-mail giriniz!", "UYARI!");
                return;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Lütfen parola giriniz!", "UYARI!");
                return;
            }
            var Kullanici =  context.Kullanici.Where(k => k.Mail == txtMail.Text && k.Parola == txtParola.Text);
              if (Kullanici.Count() == 0)
               {
                MessageBox.Show("HATALI GİRİŞ!", "YANLIŞ E-MAİL - PAROLA KOMBİNASYONU!", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            else
               {
                MessageBox.Show("GİRİŞ BAŞARILI!", "DOĞRU E-MAİL - PAROLA KOMBİNASYONU!", MessageBoxButtons.OK);
                AnaSayfa anaSayfa = new AnaSayfa(false);
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

        private void picGeri_Click(object sender, EventArgs e)
        {
            BarinakTakipSistemi barinakTakip = new BarinakTakipSistemi();
            barinakTakip.Show();
            this.Hide();
        }
    }
}
