namespace RISOFT
{
    partial class urunbilgisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunbilgisi));
            this.lblurunıd = new System.Windows.Forms.Label();
            this.lblurunadi = new System.Windows.Forms.Label();
            this.lblstok = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.txturunıd = new System.Windows.Forms.TextBox();
            this.txturunfiyat = new System.Windows.Forms.TextBox();
            this.txturunstok = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblurunıd
            // 
            this.lblurunıd.AutoSize = true;
            this.lblurunıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblurunıd.Location = new System.Drawing.Point(50, 34);
            this.lblurunıd.Name = "lblurunıd";
            this.lblurunıd.Size = new System.Drawing.Size(84, 25);
            this.lblurunıd.TabIndex = 0;
            this.lblurunıd.Text = "Ürün ID:";
            // 
            // lblurunadi
            // 
            this.lblurunadi.AutoSize = true;
            this.lblurunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblurunadi.Location = new System.Drawing.Point(50, 100);
            this.lblurunadi.Name = "lblurunadi";
            this.lblurunadi.Size = new System.Drawing.Size(94, 25);
            this.lblurunadi.TabIndex = 0;
            this.lblurunadi.Text = "Ürün Adı:";
            // 
            // lblstok
            // 
            this.lblstok.AutoSize = true;
            this.lblstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstok.Location = new System.Drawing.Point(50, 166);
            this.lblstok.Name = "lblstok";
            this.lblstok.Size = new System.Drawing.Size(58, 25);
            this.lblstok.TabIndex = 0;
            this.lblstok.Text = "Stok:";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfiyat.Location = new System.Drawing.Point(50, 227);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(60, 25);
            this.lblfiyat.TabIndex = 0;
            this.lblfiyat.Text = "Fiyat:";
            // 
            // txturunad
            // 
            this.txturunad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunad.Location = new System.Drawing.Point(207, 95);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(271, 30);
            this.txturunad.TabIndex = 3;
            // 
            // txturunıd
            // 
            this.txturunıd.Enabled = false;
            this.txturunıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunıd.Location = new System.Drawing.Point(207, 29);
            this.txturunıd.Name = "txturunıd";
            this.txturunıd.Size = new System.Drawing.Size(271, 30);
            this.txturunıd.TabIndex = 1;
            // 
            // txturunfiyat
            // 
            this.txturunfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunfiyat.Location = new System.Drawing.Point(207, 222);
            this.txturunfiyat.Name = "txturunfiyat";
            this.txturunfiyat.Size = new System.Drawing.Size(271, 30);
            this.txturunfiyat.TabIndex = 9;
            this.txturunfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txturunfiyat_KeyPress);
            // 
            // txturunstok
            // 
            this.txturunstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunstok.Location = new System.Drawing.Point(207, 161);
            this.txturunstok.Name = "txturunstok";
            this.txturunstok.Size = new System.Drawing.Size(271, 30);
            this.txturunstok.TabIndex = 7;
            this.txturunstok.TextChanged += new System.EventHandler(this.txturunstok_TextChanged);
            this.txturunstok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txturunstok_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 324);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(847, 203);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(187, 49);
            this.btnsil.TabIndex = 12;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(847, 29);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(187, 49);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(847, 111);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(187, 49);
            this.btnguncelle.TabIndex = 11;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // urunbilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1199, 625);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txturunıd);
            this.Controls.Add(this.txturunstok);
            this.Controls.Add(this.txturunfiyat);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.lblstok);
            this.Controls.Add(this.lblurunadi);
            this.Controls.Add(this.lblurunıd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "urunbilgisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RISOFT ÜRÜN BİLGİ SİSTEMİ";
            this.Load += new System.EventHandler(this.urunbilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblurunıd;
        private System.Windows.Forms.Label lblurunadi;
        private System.Windows.Forms.Label lblstok;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.TextBox txturunıd;
        private System.Windows.Forms.TextBox txturunfiyat;
        private System.Windows.Forms.TextBox txturunstok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnguncelle;
    }
}