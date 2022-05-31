using BarinakTakip.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class AnaSayfa : Form
    {
        ApplicationConnectionDb context = new ApplicationConnectionDb();
        Boolean ekledenMiGeldi = false;

        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }

        public AnaSayfa(Boolean ekledenMiGeldi)
        {
            InitializeComponent();
            this.ekledenMiGeldi = ekledenMiGeldi;
            barinakGrid.DataSource = context.Barinak.ToList();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            this.Text = "Ana Sayfa";
            this.AcceptButton = butonGuncelle; this.CancelButton = butonCikis;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            if (ekledenMiGeldi)
            {
                MessageBox.Show("Barınak başarıyla eklendi.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarinakEkle barinakEkle = new BarinakEkle();
            barinakEkle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (barinakGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("LÜTFEN BİR BARINAK SEÇİN!", "UYARI");
                return;
            }

                if (barinakGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.barinakGrid.SelectedRows[0];
                string id = row.Cells["id"].Value.ToString();
                Barinak barinak = context.Barinak.Find(Int32.Parse(id));
                context.Remove(barinak);
                context.SaveChanges();
                barinakGrid.DataSource = context.Barinak.ToList();
                MessageBox.Show("BARINAK SİLİNDİ.", "İŞLEM BAŞARILI!");

            }
        }

        private void barinakGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void barinakGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (barinakGrid.SelectedRows.Count != 0)
            {


                DataGridViewRow row = this.barinakGrid.SelectedRows[0];
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtIl.Text = row.Cells["Il"].Value.ToString();
                txtIlce.Text = row.Cells["Ilce"].Value.ToString();
                txtAdres.Text = row.Cells["Adres"].Value.ToString();
                txtKapasite.Text = row.Cells["Kapasite"].Value.ToString();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (barinakGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("LÜTFEN BİR BARINAK SEÇİN!", "UYARI");
                return;
            }
            if (barinakGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.barinakGrid.SelectedRows[0];
                string id = row.Cells["id"].Value.ToString();
                Barinak bulunanBarinak = context.Barinak.Find(Int32.Parse(id));

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
                    Barinak barinak = new Barinak
                    {
                        Ad = txtAd.Text,
                        Il = txtIl.Text,
                        Ilce = txtIlce.Text,
                        Adres = txtAdres.Text,
                        Kapasite = int.Parse(txtKapasite.Text),
                        Id = Int32.Parse(id)
                    };
                    context.Entry(bulunanBarinak).CurrentValues.SetValues(barinak);

                    context.SaveChanges();
                    barinakGrid.DataSource = context.Barinak.ToList();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (barinakGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("LÜTFEN BİR BARINAK SEÇİN!", "UYARI");
                return;
            }
                if (barinakGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.barinakGrid.SelectedRows[0];
                string id = row.Cells["id"].Value.ToString();
                HayvanlariListele form5 = new HayvanlariListele(Int32.Parse(id),txtAd.Text);
                form5.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BarinakTakipSistemi barinakTakip = new BarinakTakipSistemi();
            barinakTakip.Show();
            this.Hide();
        }

       
    }
}
