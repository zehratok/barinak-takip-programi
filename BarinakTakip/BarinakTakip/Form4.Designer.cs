namespace BarinakTakip
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.barinakGrid = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            this.butonEkle = new System.Windows.Forms.Button();
            this.butonSil = new System.Windows.Forms.Button();
            this.butonGuncelle = new System.Windows.Forms.Button();
            this.butonListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butonCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.barinakGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barinakGrid
            // 
            this.barinakGrid.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.barinakGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barinakGrid.Location = new System.Drawing.Point(11, 64);
            this.barinakGrid.Margin = new System.Windows.Forms.Padding(2);
            this.barinakGrid.Name = "barinakGrid";
            this.barinakGrid.RowHeadersWidth = 51;
            this.barinakGrid.RowTemplate.Height = 24;
            this.barinakGrid.Size = new System.Drawing.Size(646, 350);
            this.barinakGrid.TabIndex = 1;
            this.barinakGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.barinakGrid_RowStateChanged);
            this.barinakGrid.SelectionChanged += new System.EventHandler(this.barinakGrid_SelectionChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(9, 44);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(92, 20);
            this.txtAd.TabIndex = 2;
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(105, 44);
            this.txtIl.Margin = new System.Windows.Forms.Padding(2);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(92, 20);
            this.txtIl.TabIndex = 3;
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(201, 44);
            this.txtIlce.Margin = new System.Windows.Forms.Padding(2);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(92, 20);
            this.txtIlce.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(297, 44);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(92, 20);
            this.txtAdres.TabIndex = 5;
            // 
            // txtKapasite
            // 
            this.txtKapasite.Location = new System.Drawing.Point(396, 44);
            this.txtKapasite.Margin = new System.Windows.Forms.Padding(2);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.Size = new System.Drawing.Size(92, 20);
            this.txtKapasite.TabIndex = 6;
            // 
            // butonEkle
            // 
            this.butonEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.butonEkle.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonEkle.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.butonEkle.Location = new System.Drawing.Point(674, 243);
            this.butonEkle.Margin = new System.Windows.Forms.Padding(2);
            this.butonEkle.Name = "butonEkle";
            this.butonEkle.Size = new System.Drawing.Size(203, 79);
            this.butonEkle.TabIndex = 7;
            this.butonEkle.Text = "BARINAK EKLE";
            this.butonEkle.UseVisualStyleBackColor = false;
            this.butonEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // butonSil
            // 
            this.butonSil.BackColor = System.Drawing.Color.DarkRed;
            this.butonSil.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonSil.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.butonSil.Location = new System.Drawing.Point(674, 326);
            this.butonSil.Margin = new System.Windows.Forms.Padding(2);
            this.butonSil.Name = "butonSil";
            this.butonSil.Size = new System.Drawing.Size(203, 79);
            this.butonSil.TabIndex = 8;
            this.butonSil.Text = "BARINAĞI SİL";
            this.butonSil.UseVisualStyleBackColor = false;
            this.butonSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // butonGuncelle
            // 
            this.butonGuncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.butonGuncelle.Font = new System.Drawing.Font("Elephant", 13.25F);
            this.butonGuncelle.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.butonGuncelle.Location = new System.Drawing.Point(674, 429);
            this.butonGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.butonGuncelle.Name = "butonGuncelle";
            this.butonGuncelle.Size = new System.Drawing.Size(203, 64);
            this.butonGuncelle.TabIndex = 9;
            this.butonGuncelle.Text = "BİLGİLERİ GÜNCELLE";
            this.butonGuncelle.UseVisualStyleBackColor = false;
            this.butonGuncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // butonListele
            // 
            this.butonListele.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.butonListele.Font = new System.Drawing.Font("Elephant", 13F);
            this.butonListele.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.butonListele.Location = new System.Drawing.Point(674, 160);
            this.butonListele.Margin = new System.Windows.Forms.Padding(2);
            this.butonListele.Name = "butonListele";
            this.butonListele.Size = new System.Drawing.Size(203, 79);
            this.butonListele.TabIndex = 10;
            this.butonListele.Text = "HAYVAN LİSTESİ";
            this.butonListele.UseVisualStyleBackColor = false;
            this.butonListele.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "SİSTEME KAYITLI BARINAKLAR";
            // 
            // butonCikis
            // 
            this.butonCikis.BackColor = System.Drawing.Color.DarkRed;
            this.butonCikis.Font = new System.Drawing.Font("Elephant", 18.75F);
            this.butonCikis.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.butonCikis.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.butonCikis.Location = new System.Drawing.Point(674, 77);
            this.butonCikis.Margin = new System.Windows.Forms.Padding(2);
            this.butonCikis.Name = "butonCikis";
            this.butonCikis.Size = new System.Drawing.Size(203, 79);
            this.butonCikis.TabIndex = 12;
            this.butonCikis.Text = "ÇIKIŞ YAP";
            this.butonCikis.UseVisualStyleBackColor = false;
            this.butonCikis.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 50);
            this.panel1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Elephant", 13F);
            this.label5.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label5.Location = new System.Drawing.Point(398, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Kapasite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 13F);
            this.label4.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label4.Location = new System.Drawing.Point(314, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 13F);
            this.label3.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Location = new System.Drawing.Point(225, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "İlçe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 13F);
            this.label2.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Location = new System.Drawing.Point(140, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "İl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Elephant", 13F);
            this.label6.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label6.Location = new System.Drawing.Point(40, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ad";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.txtAd);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtIl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtIlce);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAdres);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtKapasite);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(158, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 76);
            this.panel2.TabIndex = 33;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butonCikis);
            this.Controls.Add(this.butonListele);
            this.Controls.Add(this.butonGuncelle);
            this.Controls.Add(this.butonSil);
            this.Controls.Add(this.butonEkle);
            this.Controls.Add(this.barinakGrid);
            this.Name = "AnaSayfa";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barinakGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView barinakGrid;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.Button butonEkle;
        private System.Windows.Forms.Button butonSil;
        private System.Windows.Forms.Button butonGuncelle;
        private System.Windows.Forms.Button butonListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}