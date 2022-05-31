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
    public partial class BarinakEkle : Form
    {
        ApplicationConnectionDb context = new ApplicationConnectionDb();
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        public BarinakEkle()
        {
            InitializeComponent();
        }

        private void BarinakEkle_Load(object sender, EventArgs e)
        {
            this.Text = "Barınak Ekle";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = butonEkle;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa(false);
            anaSayfa.Show();
            this.Hide();
        }

        private void butonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAd.Text == "")
                {
                    MessageBox.Show("Lütfen ad bilgisi giriniz!");
                    return;
                }
                if (txtIl.Text == "")
                {
                    MessageBox.Show("Lütfen il bilgisi giriniz!");
                    return;
                }
                if (txtIlce.Text == "")
                {
                    MessageBox.Show("Lütfen ilçe bilgisi giriniz!");
                    return;
                }
                if (txtAdres.Text == "")
                {
                    MessageBox.Show("Lütfen adres bilgisi giriniz!");
                    return;
                }
                if (txtKapasite.Text == "")
                {
                    MessageBox.Show("Lütfen kapasite bilgisi giriniz!");
                    return;
                }
                if (SayiMi(txtKapasite.Text) == false)
                {
                    MessageBox.Show("Lütfen kapasite bilgisini sayı olarak giriniz!");
                    return;
                }
                else
                {
                    Barinak barinak = new Barinak {
                        Ad = txtAd.Text,
                        Il = txtIl.Text,
                        Ilce = txtIlce.Text,
                        Adres = txtAdres.Text,
                        Kapasite = int.Parse(txtKapasite.Text)
                    };
                    context.Add(barinak);
                    context.SaveChanges();
                    AnaSayfa anaSayfa = new AnaSayfa(true);
                    anaSayfa.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Barınak eklenirken bir hata oluştu.","HATA");
            }
      
        }
    }
}
