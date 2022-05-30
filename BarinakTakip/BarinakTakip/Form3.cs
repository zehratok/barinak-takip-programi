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

        }

        private void butonKaydol_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici kullanici = new Kullanici { Mail = txtmail.Text, Ad = txtKullaniciAd.Text, Soyad = txtKullaniciSoyad.Text, Parola = txtParola.Text };
            context.Add(kullanici);
            context.SaveChanges();
                GirisEkrani girisEkrani = new GirisEkrani(true);
                girisEkrani.Show();
                this.Hide();
               

            }
            catch(Exception ex)
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
    }
}
