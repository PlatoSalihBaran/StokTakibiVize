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
    public partial class StokEksilt : Form
    {
        UrunBusiness ub = new UrunBusiness();
        public StokEksilt()
        {
            InitializeComponent();
        }
        public string barkod { get; set; }
        private void StokEksilt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ub.StokSil(new Urun(barkod.ToString(), Convert.ToInt32(txtStokAAdt.Text)));
            Urunler u = new Urunler();
            this.Hide();
        }
    }
}
