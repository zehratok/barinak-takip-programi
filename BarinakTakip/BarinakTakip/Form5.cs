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
    public partial class HayvanlariListele : Form
    {
        int barinakId;
        ApplicationConnectionDb context = new ApplicationConnectionDb();
        string BarinakAd;
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        public HayvanlariListele(int barinakId, string barinakAd)
        {
            InitializeComponent();
            this.barinakId = barinakId;
            txtBaslik.Text = barinakAd;
            BarinakAd = barinakAd;
            gridHayvanListele.DataSource = context.Hayvan.Where(i=>i.BarinakId == barinakId).ToList();

        }
       

       

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (gridHayvanListele.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.gridHayvanListele.SelectedRows[0];
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtTur.Text = row.Cells["Tur"].Value.ToString();
                txtCins.Text = row.Cells["Cins"].Value.ToString();
                txtYas.Text = row.Cells["Yas"].Value.ToString();
                txtSaglik.Text = row.Cells["Saglik"].Value.ToString();

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Text = txtBaslik.Text;
            this.AcceptButton = butonGuncelle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa(false);
            anaSayfa.Show();
            this.Hide();
        }

        private void butonEkle_Click(object sender, EventArgs e)
        {
            HayvanEkle hayvanEkle = new HayvanEkle(barinakId,BarinakAd);
            hayvanEkle.Show();
            this.Hide();
        }

        private void butonDetay_Click(object sender, EventArgs e)
        {
            if (gridHayvanListele.SelectedRows.Count == 0)
            {
                MessageBox.Show("LÜTFEN BİR HAYVAN SEÇİN!", "UYARI");
                return;
            }
            if (gridHayvanListele.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.gridHayvanListele.SelectedRows[0];
                string id = row.Cells["id"].Value.ToString();
                HayvanDetay hayvanDetay = new HayvanDetay(barinakId, Int32.Parse(id), txtBaslik.Text, txtAd.Text, txtTur.Text, txtCins.Text, txtSaglik.Text, txtYas.Text);
                hayvanDetay.Show();
            }
        }

        private void butonGuncelle_Click(object sender, EventArgs e)
        {

            if (gridHayvanListele.SelectedRows.Count == 0)
            {
                MessageBox.Show("LÜTFEN BİR HAYVAN SEÇİN!", "UYARI");
                return;
            }
            if (gridHayvanListele.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.gridHayvanListele.SelectedRows[0];
                string id = row.Cells["id"].Value.ToString();
                Hayvan bulunanHayvan = context.Hayvan.Find(Int32.Parse(id));

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
                    Hayvan barinak = new Hayvan
                    {
                        Ad = txtAd.Text,
                        Tur = txtTur.Text,
                        Cins = txtCins.Text,
                        Saglik = txtSaglik.Text,
                        Yas = txtYas.Text,
                        BarinakId= barinakId,
                        Id = Int32.Parse(id)
                    };
                    context.Entry(bulunanHayvan).CurrentValues.SetValues(barinak);

                    context.SaveChanges();
                    gridHayvanListele.DataSource = context.Hayvan.Where(i => i.BarinakId == barinakId).ToList();
                }
            }
        }

        private void butonSil_Click(object sender, EventArgs e)
        {
            if (gridHayvanListele.SelectedRows.Count == 0)
            {
                MessageBox.Show("LÜTFEN BİR HAYVAN SEÇİN!", "UYARI!");
                return;
            }

            if (gridHayvanListele.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.gridHayvanListele.SelectedRows[0];
                string id = row.Cells["id"].Value.ToString();
                Hayvan hayvan = context.Hayvan.Find(Int32.Parse(id));
                context.Remove(hayvan);
                context.SaveChanges();
                gridHayvanListele.DataSource = context.Hayvan.Where(i => i.BarinakId == barinakId).ToList();
                MessageBox.Show("HAYVAN SİLİNDİ.", "İŞLEM BAŞARILI!");

            }
        }
    }
}
