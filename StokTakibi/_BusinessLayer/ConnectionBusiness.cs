using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer
{
    public class ConnectionBusiness
    {
        private SqlConnection bgl;
        private string bglm = "Data Source=BARAN\\BARAN;Initial Catalog=StokTakibii;Integrated Security=True";

        public SqlConnection OpenConnection()
        {
            bgl = new SqlConnection(this.bglm);
            bgl.Open();
            return bgl;
        }

        public void CloseConnection()
        {
            bgl.Close();
        }

    }
}
