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
    public partial class KayitEkrani : Form
    {

        ApplicationConnectionDb context = new ApplicationConnectionDb();
        //bunu her forma koycan
        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Kayıt Ekranı";
            this.AcceptButton = butonKaydol; this.CancelButton = butonIptal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void butonKaydol_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtAd.Text == "")
                {
                    MessageBox.Show("Lütfen ad bilgisi giriniz!");
                    return;
                }
                if (txtSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen soyad bilgisi giriniz!");
                    return;
                }
                if (txtMail.Text == "")
                {
                    MessageBox.Show("Lütfen e-mail bilgisi giriniz!");
                    return;
                }
                if (txtParola.Text == "")
                {
                    MessageBox.Show("Lütfen parola bilgisi giriniz!");
                    return;
                }
                else
                {
                    Kullanici kullanici = new Kullanici { Mail = txtMail.Text, Ad = txtAd.Text, Soyad = txtSoyad.Text, Parola = txtParola.Text };
                    context.Add(kullanici);
                    context.SaveChanges();
                    GirisEkrani girisEkrani = new GirisEkrani(true);
                    girisEkrani.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı oluşturulamadı");
            }
           
        }

        private void butonIptal_Click(object sender, EventArgs e)
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
