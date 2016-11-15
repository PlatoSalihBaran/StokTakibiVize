namespace _PresentationLayer
{
    partial class HomeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.stomasyonhomeList = new System.Windows.Forms.DataGridView();
            this.U_Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_StokAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.stomasyonhomeList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "ÜRÜNLER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 75);
            this.button3.TabIndex = 0;
            this.button3.Text = "KULLANICILAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // stomasyonhomeList
            // 
            this.stomasyonhomeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stomasyonhomeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stomasyonhomeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stomasyonhomeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.U_Barkod,
            this.U_ID,
            this.U_Adi,
            this.U_Fiyat,
            this.U_StokAdet});
            this.stomasyonhomeList.Location = new System.Drawing.Point(0, 22);
            this.stomasyonhomeList.Name = "stomasyonhomeList";
            this.stomasyonhomeList.Size = new System.Drawing.Size(800, 418);
            this.stomasyonhomeList.TabIndex = 1;
            // 
            // U_Barkod
            // 
            this.U_Barkod.DataPropertyName = "U_Barkod";
            this.U_Barkod.HeaderText = "ÜRÜN BARKODU";
            this.U_Barkod.Name = "U_Barkod";
            // 
            // U_ID
            // 
            this.U_ID.DataPropertyName = "U_ID";
            this.U_ID.HeaderText = "ID";
            this.U_ID.Name = "U_ID";
            this.U_ID.Visible = false;
            // 
            // U_Adi
            // 
            this.U_Adi.DataPropertyName = "U_Adi";
            this.U_Adi.HeaderText = "ÜRÜN ADI";
            this.U_Adi.Name = "U_Adi";
            // 
            // U_Fiyat
            // 
            this.U_Fiyat.DataPropertyName = "U_Fiyat";
            this.U_Fiyat.HeaderText = "ÜRÜN FİYATI";
            this.U_Fiyat.Name = "U_Fiyat";
            // 
            // U_StokAdet
            // 
            this.U_StokAdet.DataPropertyName = "U_StokAdet";
            this.U_StokAdet.HeaderText = "ÜRÜN STOĞU";
            this.U_StokAdet.Name = "U_StokAdet";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.stomasyonhomeList);
            this.groupBox1.Location = new System.Drawing.Point(4, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 440);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SON EKLENEN ÜRÜNLER";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomeForm";
            this.Text = "Stomasyon";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stomasyonhomeList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView stomasyonhomeList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_StokAdet;
    }
}