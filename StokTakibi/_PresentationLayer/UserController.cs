using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PresentationLayer
{
    class UserController
    {
        public void LoginAc()
        {
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }
    }
}
