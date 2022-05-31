namespace BarinakTakip
{
    partial class BarinakTakipSistemi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarinakTakipSistemi));
            this.butonGiris = new System.Windows.Forms.Button();
            this.butonKayit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butonGiris
            // 
            this.butonGiris.BackColor = System.Drawing.Color.SeaGreen;
            this.butonGiris.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonGiris.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.butonGiris.Location = new System.Drawing.Point(484, 300);
            this.butonGiris.Name = "butonGiris";
            this.butonGiris.Size = new System.Drawing.Size(151, 62);
            this.butonGiris.TabIndex = 8;
            this.butonGiris.Text = "GİRİŞ YAP";
            this.butonGiris.UseVisualStyleBackColor = false;
            this.butonGiris.Click += new System.EventHandler(this.butonGiris_Click);
            // 
            // butonKayit
            // 
            this.butonKayit.BackColor = System.Drawing.Color.SeaGreen;
            this.butonKayit.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonKayit.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.butonKayit.Location = new System.Drawing.Point(292, 300);
            this.butonKayit.Name = "butonKayit";
            this.butonKayit.Size = new System.Drawing.Size(151, 62);
            this.butonKayit.TabIndex = 12;
            this.butonKayit.Text = "KAYIT OL";
            this.butonKayit.UseVisualStyleBackColor = false;
            this.butonKayit.Click += new System.EventHandler(this.butonKayit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label6.Location = new System.Drawing.Point(222, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(528, 41);
            this.label6.TabIndex = 13;
            this.label6.Text = "BARINAK TAKİP SİSTEMİ";
            // 
            // BarinakTakipSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butonKayit);
            this.Controls.Add(this.butonGiris);
            this.Name = "BarinakTakipSistemi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butonGiris;
        private System.Windows.Forms.Button butonKayit;
        private System.Windows.Forms.Label label6;
    }
}

