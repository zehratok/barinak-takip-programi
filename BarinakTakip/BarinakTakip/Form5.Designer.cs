namespace BarinakTakip
{
    partial class HayvanlariListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HayvanlariListele));
            this.gridHayvanListele = new System.Windows.Forms.DataGridView();
            this.butonGeri = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBaslik = new System.Windows.Forms.Label();
            this.butonGuncelle = new System.Windows.Forms.Button();
            this.butonSil = new System.Windows.Forms.Button();
            this.butonEkle = new System.Windows.Forms.Button();
            this.butonDetay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaglik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridHayvanListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butonGeri)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHayvanListele
            // 
            this.gridHayvanListele.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gridHayvanListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHayvanListele.Location = new System.Drawing.Point(51, 67);
            this.gridHayvanListele.Margin = new System.Windows.Forms.Padding(2);
            this.gridHayvanListele.Name = "gridHayvanListele";
            this.gridHayvanListele.RowHeadersWidth = 51;
            this.gridHayvanListele.RowTemplate.Height = 24;
            this.gridHayvanListele.Size = new System.Drawing.Size(588, 305);
            this.gridHayvanListele.TabIndex = 0;
            this.gridHayvanListele.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // butonGeri
            // 
            this.butonGeri.Image = ((System.Drawing.Image)(resources.GetObject("butonGeri.Image")));
            this.butonGeri.Location = new System.Drawing.Point(11, 12);
            this.butonGeri.Name = "butonGeri";
            this.butonGeri.Size = new System.Drawing.Size(34, 36);
            this.butonGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.butonGeri.TabIndex = 13;
            this.butonGeri.TabStop = false;
            this.butonGeri.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.txtBaslik);
            this.panel1.Location = new System.Drawing.Point(51, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 50);
            this.panel1.TabIndex = 28;
            // 
            // txtBaslik
            // 
            this.txtBaslik.AutoSize = true;
            this.txtBaslik.BackColor = System.Drawing.Color.Transparent;
            this.txtBaslik.Font = new System.Drawing.Font("Elephant", 15F);
            this.txtBaslik.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBaslik.Location = new System.Drawing.Point(51, 10);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(0, 26);
            this.txtBaslik.TabIndex = 11;
            this.txtBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // butonGuncelle
            // 
            this.butonGuncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.butonGuncelle.Font = new System.Drawing.Font("Elephant", 13.25F);
            this.butonGuncelle.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.butonGuncelle.Location = new System.Drawing.Point(669, 397);
            this.butonGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.butonGuncelle.Name = "butonGuncelle";
            this.butonGuncelle.Size = new System.Drawing.Size(203, 64);
            this.butonGuncelle.TabIndex = 31;
            this.butonGuncelle.Text = "BİLGİLERİ GÜNCELLE";
            this.butonGuncelle.UseVisualStyleBackColor = false;
            this.butonGuncelle.Click += new System.EventHandler(this.butonGuncelle_Click);
            // 
            // butonSil
            // 
            this.butonSil.BackColor = System.Drawing.Color.DarkRed;
            this.butonSil.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonSil.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.butonSil.Location = new System.Drawing.Point(669, 293);
            this.butonSil.Margin = new System.Windows.Forms.Padding(2);
            this.butonSil.Name = "butonSil";
            this.butonSil.Size = new System.Drawing.Size(203, 79);
            this.butonSil.TabIndex = 30;
            this.butonSil.Text = "HAYVANI SİL";
            this.butonSil.UseVisualStyleBackColor = false;
            this.butonSil.Click += new System.EventHandler(this.butonSil_Click);
            // 
            // butonEkle
            // 
            this.butonEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.butonEkle.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonEkle.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.butonEkle.Location = new System.Drawing.Point(669, 181);
            this.butonEkle.Margin = new System.Windows.Forms.Padding(2);
            this.butonEkle.Name = "butonEkle";
            this.butonEkle.Size = new System.Drawing.Size(203, 79);
            this.butonEkle.TabIndex = 29;
            this.butonEkle.Text = "HAYVAN EKLE";
            this.butonEkle.UseVisualStyleBackColor = false;
            this.butonEkle.Click += new System.EventHandler(this.butonEkle_Click);
            // 
            // butonDetay
            // 
            this.butonDetay.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.butonDetay.Font = new System.Drawing.Font("Elephant", 13F);
            this.butonDetay.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.butonDetay.Location = new System.Drawing.Point(669, 67);
            this.butonDetay.Margin = new System.Windows.Forms.Padding(2);
            this.butonDetay.Name = "butonDetay";
            this.butonDetay.Size = new System.Drawing.Size(203, 79);
            this.butonDetay.TabIndex = 32;
            this.butonDetay.Text = "DETAY";
            this.butonDetay.UseVisualStyleBackColor = false;
            this.butonDetay.Click += new System.EventHandler(this.butonDetay_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.txtAd);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTur);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCins);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtYas);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSaglik);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(200, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 76);
            this.panel2.TabIndex = 34;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(4, 45);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(83, 20);
            this.txtAd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Elephant", 13F);
            this.label5.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label5.Location = new System.Drawing.Point(273, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Sağlık";
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(91, 45);
            this.txtTur.Margin = new System.Windows.Forms.Padding(2);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(83, 20);
            this.txtTur.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 13F);
            this.label4.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label4.Location = new System.Drawing.Point(370, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Yaş";
            // 
            // txtCins
            // 
            this.txtCins.Location = new System.Drawing.Point(178, 45);
            this.txtCins.Margin = new System.Windows.Forms.Padding(2);
            this.txtCins.Name = "txtCins";
            this.txtCins.Size = new System.Drawing.Size(83, 20);
            this.txtCins.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 13F);
            this.label3.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Location = new System.Drawing.Point(195, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cins";
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(352, 45);
            this.txtYas.Margin = new System.Windows.Forms.Padding(2);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(83, 20);
            this.txtYas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 13F);
            this.label2.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Location = new System.Drawing.Point(110, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tür";
            // 
            // txtSaglik
            // 
            this.txtSaglik.Location = new System.Drawing.Point(265, 45);
            this.txtSaglik.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaglik.Name = "txtSaglik";
            this.txtSaglik.Size = new System.Drawing.Size(83, 20);
            this.txtSaglik.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Elephant", 13F);
            this.label6.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label6.Location = new System.Drawing.Point(29, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // HayvanlariListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.butonDetay);
            this.Controls.Add(this.butonGuncelle);
            this.Controls.Add(this.butonSil);
            this.Controls.Add(this.butonEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butonGeri);
            this.Controls.Add(this.gridHayvanListele);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HayvanlariListele";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHayvanListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butonGeri)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridHayvanListele;
        private System.Windows.Forms.PictureBox butonGeri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtBaslik;
        private System.Windows.Forms.Button butonGuncelle;
        private System.Windows.Forms.Button butonSil;
        private System.Windows.Forms.Button butonEkle;
        private System.Windows.Forms.Button butonDetay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaglik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}