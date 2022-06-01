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
    public partial class HayvanEkle : Form
    {
        ApplicationConnectionDb context = new ApplicationConnectionDb();
        int BarinakId;
        string BarinakAd;
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        public HayvanEkle(int barinakId, string barinakAd)
        {
            InitializeComponent();
            BarinakId = barinakId;
            BarinakAd = barinakAd;
        }

        private void HayvanEkle_Load(object sender, EventArgs e)
        {
            this.Text = "Hayvan Ekle";
            this.AcceptButton = butonEkle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void picGeri_Click(object sender, EventArgs e)
        {
            HayvanlariListele hayvanlariListele = new HayvanlariListele(BarinakId, BarinakAd);
            hayvanlariListele.Show();
            this.Hide();
        }

        private void butonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAd.Text == "")
                {
                    MessageBox.Show("Lütfen ad bilgisi giriniz!", "UYARI");
                    return;
                }
                if (txtTur.Text == "")
                {
                    MessageBox.Show("Lütfen tür bilgisi giriniz!", "UYARI");
                    return;
                }
                if (txtCins.Text == "")
                {
                    MessageBox.Show("Lütfen cins bilgisi giriniz!", "UYARI");
                    return;
                }
                if (txtSaglik.Text == "")
                {
                    MessageBox.Show("Lütfen sağlık bilgisi giriniz!", "UYARI");
                    return;
                }
                if (txtYas.Text == "")
                {
                    MessageBox.Show("Lütfen yaş bilgisi giriniz!", "UYARI");
                    return;
                }
                if (SayiMi(txtYas.Text) == false)
                {
                    MessageBox.Show("Lütfen yaş bilgisini sayı olarak giriniz!", "UYARI");
                    return;
                }
                else
                {
                    Hayvan hayvan = new Hayvan
                    {
                        BarinakId = BarinakId,
                        Ad = txtAd.Text,
                        Tur = txtTur.Text,
                        Cins = txtCins.Text,
                        Saglik = txtSaglik.Text,
                        Yas = txtYas.Text
                    };
                    context.Add(hayvan);
                    context.SaveChanges();
                    MessageBox.Show("HAYVAN EKLEME İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ!", "BAŞARILI!");
                    HayvanlariListele hayvanlariListele = new HayvanlariListele(BarinakId, BarinakAd);
                    hayvanlariListele.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvan eklenirken bir hata oluştu.", "HATA!");
            }
            
        }
    }
}
