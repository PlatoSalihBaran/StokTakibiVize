namespace _PresentationLayer
{
    partial class StokEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStokEAdt = new System.Windows.Forms.TextBox();
            this.btnStkEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adet";
            // 
            // txtStokEAdt
            // 
            this.txtStokEAdt.Location = new System.Drawing.Point(43, 49);
            this.txtStokEAdt.Name = "txtStokEAdt";
            this.txtStokEAdt.Size = new System.Drawing.Size(106, 20);
            this.txtStokEAdt.TabIndex = 1;
            // 
            // btnStkEkle
            // 
            this.btnStkEkle.Location = new System.Drawing.Point(43, 89);
            this.btnStkEkle.Name = "btnStkEkle";
            this.btnStkEkle.Size = new System.Drawing.Size(106, 33);
            this.btnStkEkle.TabIndex = 2;
            this.btnStkEkle.Text = "EKLE";
            this.btnStkEkle.UseVisualStyleBackColor = true;
            this.btnStkEkle.Click += new System.EventHandler(this.btnStkEkle_Click);
            // 
            // StokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 148);
            this.Controls.Add(this.btnStkEkle);
            this.Controls.Add(this.txtStokEAdt);
            this.Controls.Add(this.label1);
            this.Name = "StokEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokEkle";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StokEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStokEAdt;
        private System.Windows.Forms.Button btnStkEkle;
    }
}