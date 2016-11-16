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
    public partial class StokEkle : Form
    {
        UrunBusiness ub = new UrunBusiness();
        public StokEkle()
        {
            InitializeComponent();
        }
        public string barkod { get; set; }
        private void btnStkEkle_Click(object sender, EventArgs e)
        {
        ub.StokEkle(new Urun(barkod.ToString(), Convert.ToInt32(txtStokEAdt.Text)));
        this.Hide();
        }

        private void StokEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
