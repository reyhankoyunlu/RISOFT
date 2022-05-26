namespace RISOFT
{
    partial class RISOFT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RISOFT));
            this.btn_urun = new System.Windows.Forms.Button();
            this.btn_calisan = new System.Windows.Forms.Button();
            this.btn_musteri = new System.Windows.Forms.Button();
            this.btn_siparis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_urun
            // 
            this.btn_urun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_urun.Location = new System.Drawing.Point(33, 192);
            this.btn_urun.Name = "btn_urun";
            this.btn_urun.Size = new System.Drawing.Size(180, 61);
            this.btn_urun.TabIndex = 0;
            this.btn_urun.Text = "ÜRÜN BİLGİSİ";
            this.btn_urun.UseVisualStyleBackColor = true;
            this.btn_urun.Click += new System.EventHandler(this.btn_urun_Click);
            // 
            // btn_calisan
            // 
            this.btn_calisan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_calisan.Location = new System.Drawing.Point(318, 192);
            this.btn_calisan.Name = "btn_calisan";
            this.btn_calisan.Size = new System.Drawing.Size(180, 61);
            this.btn_calisan.TabIndex = 1;
            this.btn_calisan.Text = "ÇALIŞAN BİLGİSİ";
            this.btn_calisan.UseVisualStyleBackColor = true;
            this.btn_calisan.Click += new System.EventHandler(this.btn_calisan_Click);
            // 
            // btn_musteri
            // 
            this.btn_musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_musteri.Location = new System.Drawing.Point(596, 192);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(220, 61);
            this.btn_musteri.TabIndex = 2;
            this.btn_musteri.Text = "MÜŞTERİ BİLGİSİ";
            this.btn_musteri.UseVisualStyleBackColor = true;
            this.btn_musteri.Click += new System.EventHandler(this.btn_musteri_Click);
            // 
            // btn_siparis
            // 
            this.btn_siparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_siparis.Location = new System.Drawing.Point(912, 192);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.Size = new System.Drawing.Size(201, 61);
            this.btn_siparis.TabIndex = 3;
            this.btn_siparis.Text = "SİPARİŞ BİLGİSİ";
            this.btn_siparis.UseVisualStyleBackColor = true;
            this.btn_siparis.Click += new System.EventHandler(this.btn_siparis_Click);
            // 
            // RISOFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 575);
            this.Controls.Add(this.btn_musteri);
            this.Controls.Add(this.btn_siparis);
            this.Controls.Add(this.btn_calisan);
            this.Controls.Add(this.btn_urun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RISOFT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RISOFT YÖNETİCİ PANELİ";
            this.Load += new System.EventHandler(this.RISOFT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_urun;
        private System.Windows.Forms.Button btn_calisan;
        private System.Windows.Forms.Button btn_musteri;
        private System.Windows.Forms.Button btn_siparis;
    }
}

