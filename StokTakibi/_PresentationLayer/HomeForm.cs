using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PresentationLayer
{
    public partial class HomeForm : BaseForm
    {
        UserController us = new UserController();
        public HomeForm()
        {
            InitializeComponent();
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            us.LoginAc();
        }
    }
}
