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

        private void Urunler_Load(object sender, EventArgs e)
        {
            stomasyonurunlerList.DataSource = ub.Listele();
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
        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            ub.StokArttir(new Urun(txtBarkod.Text));
        }
    }
}
