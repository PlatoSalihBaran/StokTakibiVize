namespace _PresentationLayer
{
    partial class Urunler
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnArttir = new System.Windows.Forms.Button();
            this.btnEksilt = new System.Windows.Forms.Button();
            this.stomasyonurunlerList = new System.Windows.Forms.DataGridView();
            this.UrunlerLabel = new System.Windows.Forms.GroupBox();
            this.txtBarkod = new System.Windows.Forms.MaskedTextBox();
            this.txtStok = new System.Windows.Forms.MaskedTextBox();
            this.txtFiyat = new System.Windows.Forms.MaskedTextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.U_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_StokAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stomasyonurunlerList)).BeginInit();
            this.UrunlerLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün Barkodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Adı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(121, 57);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(132, 23);
            this.txtAdi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stok Adedi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(558, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(558, 75);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.bnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(558, 44);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnArttir
            // 
            this.btnArttir.Enabled = false;
            this.btnArttir.Location = new System.Drawing.Point(668, 12);
            this.btnArttir.Name = "btnArttir";
            this.btnArttir.Size = new System.Drawing.Size(75, 86);
            this.btnArttir.TabIndex = 10;
            this.btnArttir.Text = "STOK ARTTIR";
            this.btnArttir.UseVisualStyleBackColor = true;
            this.btnArttir.Click += new System.EventHandler(this.btnArttir_Click);
            // 
            // btnEksilt
            // 
            this.btnEksilt.Enabled = false;
            this.btnEksilt.Location = new System.Drawing.Point(749, 12);
            this.btnEksilt.Name = "btnEksilt";
            this.btnEksilt.Size = new System.Drawing.Size(75, 86);
            this.btnEksilt.TabIndex = 10;
            this.btnEksilt.Text = "STOK EKSİLT";
            this.btnEksilt.UseVisualStyleBackColor = true;
            this.btnEksilt.Click += new System.EventHandler(this.btnEksilt_Click);
            // 
            // stomasyonurunlerList
            // 
            this.stomasyonurunlerList.AllowUserToAddRows = false;
            this.stomasyonurunlerList.AllowUserToDeleteRows = false;
            this.stomasyonurunlerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stomasyonurunlerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stomasyonurunlerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stomasyonurunlerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.U_Adi,
            this.U_Barkod,
            this.U_Fiyat,
            this.U_StokAdet,
            this.U_ID});
            this.stomasyonurunlerList.Location = new System.Drawing.Point(0, 27);
            this.stomasyonurunlerList.Margin = new System.Windows.Forms.Padding(4);
            this.stomasyonurunlerList.Name = "stomasyonurunlerList";
            this.stomasyonurunlerList.ReadOnly = true;
            this.stomasyonurunlerList.Size = new System.Drawing.Size(904, 257);
            this.stomasyonurunlerList.TabIndex = 1;
            this.stomasyonurunlerList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stomasyonurunlerList_CellMouseDoubleClick);
            // 
            // UrunlerLabel
            // 
            this.UrunlerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrunlerLabel.Controls.Add(this.stomasyonurunlerList);
            this.UrunlerLabel.Location = new System.Drawing.Point(4, 105);
            this.UrunlerLabel.Margin = new System.Windows.Forms.Padding(4);
            this.UrunlerLabel.Name = "UrunlerLabel";
            this.UrunlerLabel.Padding = new System.Windows.Forms.Padding(4);
            this.UrunlerLabel.Size = new System.Drawing.Size(904, 285);
            this.UrunlerLabel.TabIndex = 6;
            this.UrunlerLabel.TabStop = false;
            this.UrunlerLabel.Text = "ÜRÜNLER";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(121, 20);
            this.txtBarkod.Mask = "00000000";
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(132, 23);
            this.txtBarkod.TabIndex = 11;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(391, 57);
            this.txtStok.Mask = "00000";
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(132, 23);
            this.txtStok.TabIndex = 12;
            this.txtStok.ValidatingType = typeof(int);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(391, 20);
            this.txtFiyat.Mask = "00000000";
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(132, 23);
            this.txtFiyat.TabIndex = 13;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(830, 12);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 86);
            this.btnYeni.TabIndex = 10;
            this.btnYeni.Text = "YENİ EKLE";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Visible = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // U_Adi
            // 
            this.U_Adi.DataPropertyName = "U_Adi";
            this.U_Adi.HeaderText = "ÜRÜN ADI";
            this.U_Adi.Name = "U_Adi";
            this.U_Adi.ReadOnly = true;
            // 
            // U_Barkod
            // 
            this.U_Barkod.DataPropertyName = "U_Barkod";
            this.U_Barkod.HeaderText = "ÜRÜN BARKODU";
            this.U_Barkod.Name = "U_Barkod";
            this.U_Barkod.ReadOnly = true;
            // 
            // U_Fiyat
            // 
            this.U_Fiyat.DataPropertyName = "U_Fiyat";
            this.U_Fiyat.HeaderText = "ÜRÜN FİYATI";
            this.U_Fiyat.Name = "U_Fiyat";
            this.U_Fiyat.ReadOnly = true;
            // 
            // U_StokAdet
            // 
            this.U_StokAdet.DataPropertyName = "U_StokAdet";
            this.U_StokAdet.HeaderText = "ÜRÜN STOĞU";
            this.U_StokAdet.Name = "U_StokAdet";
            this.U_StokAdet.ReadOnly = true;
            // 
            // U_ID
            // 
            this.U_ID.DataPropertyName = "U_ID";
            this.U_ID.HeaderText = "ID";
            this.U_ID.Name = "U_ID";
            this.U_ID.ReadOnly = true;
            this.U_ID.Visible = false;
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 394);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnEksilt);
            this.Controls.Add(this.btnArttir);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrunlerLabel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stomasyonurunlerList)).EndInit();
            this.UrunlerLabel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnArttir;
        private System.Windows.Forms.Button btnEksilt;
        private System.Windows.Forms.DataGridView stomasyonurunlerList;
        private System.Windows.Forms.GroupBox UrunlerLabel;
        private System.Windows.Forms.MaskedTextBox txtBarkod;
        private System.Windows.Forms.MaskedTextBox txtStok;
        private System.Windows.Forms.MaskedTextBox txtFiyat;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_StokAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ID;
    }
}