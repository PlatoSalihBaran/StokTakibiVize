﻿using System;
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
    public partial class Kullanicilar : BaseForm
    {
        KullaniciBusiness kb = new KullaniciBusiness();
        public Kullanicilar()
        {
            InitializeComponent();
        }

        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            stomasyonhomeList.DataSource = kb.Listele();
        }
    }
}
