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
namespace _PresentationLayer
{
    public partial class Urunler : Form
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
            int selectedId;
            selectedId = Convert.ToInt32(stomasyonurunlerList.Rows[e.RowIndex].Cells["U_ID"].Value);
            MessageBox.Show(selectedId.ToString());
        }
    }
}
