namespace _PresentationLayer
{
    partial class Kullanicilar
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
            this.stomasyonhomeList = new System.Windows.Forms.DataGridView();
            this.K_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Yetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Silme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guncelleme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Ekleme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.stomasyonhomeList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stomasyonhomeList
            // 
            this.stomasyonhomeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stomasyonhomeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stomasyonhomeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stomasyonhomeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_ID,
            this.K_Yetki,
            this.Y_ID,
            this.K_Sifre,
            this.K_Adi,
            this.Y_Adi,
            this.Silme,
            this.Guncelleme,
            this.K_Ekleme});
            this.stomasyonhomeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stomasyonhomeList.Location = new System.Drawing.Point(0, 22);
            this.stomasyonhomeList.Name = "stomasyonhomeList";
            this.stomasyonhomeList.Size = new System.Drawing.Size(800, 418);
            this.stomasyonhomeList.TabIndex = 1;
            // 
            // K_ID
            // 
            this.K_ID.DataPropertyName = "K_ID";
            this.K_ID.HeaderText = "ID";
            this.K_ID.Name = "K_ID";
            // 
            // K_Yetki
            // 
            this.K_Yetki.DataPropertyName = "K_Yetki";
            this.K_Yetki.HeaderText = "K_Yetki";
            this.K_Yetki.Name = "K_Yetki";
            this.K_Yetki.Visible = false;
            // 
            // Y_ID
            // 
            this.Y_ID.DataPropertyName = "Y_ID";
            this.Y_ID.HeaderText = "Y_ID";
            this.Y_ID.Name = "Y_ID";
            this.Y_ID.Visible = false;
            // 
            // K_Sifre
            // 
            this.K_Sifre.DataPropertyName = "K_Sifre";
            this.K_Sifre.HeaderText = "K_Sifre";
            this.K_Sifre.Name = "K_Sifre";
            this.K_Sifre.Visible = false;
            // 
            // K_Adi
            // 
            this.K_Adi.DataPropertyName = "K_Adi";
            this.K_Adi.HeaderText = "KULLANICI ADI";
            this.K_Adi.Name = "K_Adi";
            // 
            // Y_Adi
            // 
            this.Y_Adi.DataPropertyName = "Y_Adi";
            this.Y_Adi.HeaderText = "KULLANICI ROLÜ";
            this.Y_Adi.Name = "Y_Adi";
            // 
            // Silme
            // 
            this.Silme.DataPropertyName = "Silme";
            this.Silme.HeaderText = "SİLME";
            this.Silme.Name = "Silme";
            // 
            // Guncelleme
            // 
            this.Guncelleme.DataPropertyName = "Guncelleme";
            this.Guncelleme.HeaderText = "GÜNCELLEME";
            this.Guncelleme.Name = "Guncelleme";
            // 
            // K_Ekleme
            // 
            this.K_Ekleme.DataPropertyName = "K_Ekleme";
            this.K_Ekleme.HeaderText = "KULLANICI EKLEME";
            this.K_Ekleme.Name = "K_Ekleme";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.stomasyonhomeList);
            this.groupBox1.Location = new System.Drawing.Point(3, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 440);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KULLANICILAR";
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 529);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Kullanicilar";
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stomasyonhomeList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView stomasyonhomeList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Yetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Silme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guncelleme;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Ekleme;
    }
}