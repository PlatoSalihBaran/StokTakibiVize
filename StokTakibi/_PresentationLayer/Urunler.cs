using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _BusinessLayer;
using _DataLayer;

namespace _PresentationLayer
{
    public partial class Urunler : BaseForm
    {
        UrunBusiness ub = new UrunBusiness();
        public Urunler()
        {
            InitializeComponent();
        }

        public void FormTemizle()
        {
            txtBarkod.Clear();
            txtAdi.Clear();
            txtFiyat.Clear();
            txtStok.Clear();
        }
        private void Urunler_Load(object sender, EventArgs e)
        {
            stomasyonurunlerList.DataSource = ub.Listele();
            timer1.Interval = 5000;
            timer1.Enabled = true;
        }

        private void stomasyonurunlerList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedId;
            selectedId = stomasyonurunlerList.Rows[e.RowIndex].Cells["U_Barkod"].Value.ToString();
            txtBarkod.Text = selectedId.ToString();
            txtAdi.Text = stomasyonurunlerList.Rows[e.RowIndex].Cells["U_Adi"].Value.ToString();
            txtFiyat.Text = stomasyonurunlerList.Rows[e.RowIndex].Cells["U_Fiyat"].Value.ToString();
            txtStok.Text = stomasyonurunlerList.Rows[e.RowIndex].Cells["U_StokAdet"].Value.ToString();
            txtStok.Enabled = false;
            txtBarkod.Enabled = false;
            btnEkle.Enabled = false;
            btnArttir.Enabled = true;
            btnEksilt.Enabled = true;
            btnYeni.Visible = true;
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;
        }


        private void btnArttir_Click(object sender, EventArgs e)
        {
            StokEkle se = new StokEkle();
            se.barkod = txtBarkod.Text;
            se.Show();
        }


        private void bnGuncelle_Click(object sender, EventArgs e)
        {
            ub.Duzenle(new Urun(txtBarkod.Text.ToString(), txtAdi.Text.ToString(), Convert.ToDecimal(txtFiyat.Text)));
            stomasyonurunlerList.DataSource = ub.Listele();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            ub.Sil(new Urun(txtBarkod.Text.ToString()));
            stomasyonurunlerList.DataSource = ub.Listele();
            FormTemizle();
            txtStok.Enabled = true;
            txtBarkod.Enabled = true;
            btnEkle.Enabled = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "" && txtAdi.Text != "")
            {
                ub.Ekle(new Urun(txtAdi.Text.ToString(), txtBarkod.Text.ToString(), Convert.ToDecimal(txtFiyat.Text),
                    Convert.ToInt32(txtStok.Text)));
                stomasyonurunlerList.DataSource = ub.Listele();
                FormTemizle();
            }
            else
            {
                MessageBox.Show("Boş alan bulunmakta!", "DİKKAT", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtBarkod.Clear();
            txtAdi.Clear();
            txtFiyat.Clear();
            txtStok.Clear();
            txtStok.Enabled = true;
            txtBarkod.Enabled = true;
            btnEkle.Enabled = true;
            btnArttir.Enabled = false;
            btnEksilt.Enabled = false;
        }

        private void btnEksilt_Click(object sender, EventArgs e)
        {
            StokEksilt se = new StokEksilt();
            se.barkod = txtBarkod.Text;
            se.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            stomasyonurunlerList.DataSource = ub.Listele();
        }
    }
}
