using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
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

        //public static string id, ad, soyad, kullaniciTipi;

        //private void button1_Click(object sender, EventArgs e)
        //{
        //   var Kullanici =  context.Kullanici.Where(k => k.Mail == txtUsername.Text && k.Parola == txnPassword.Text);
        //    if (Kullanici.Count() == 0)
        //    {
        //        MessageBox.Show("HATALI");
        //    }
        //    else
        //    {
        //        MessageBox.Show("DOGRU");
        //    }

        //    Barinak barinak = new Barinak();
        //    barinak.Ad = "Deneme";
        //    context.Barinak.Add(barinak);
        //    context.SaveChanges();
        //}


       

        private void Form1_Load(object sender, EventArgs e)
        {

            //ApplicationConnectionDb context = new ApplicationConnectionDb();
            //dataGridView1.DataSource = context.Barinak.ToList();

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
