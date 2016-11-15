using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _DataLayer;

namespace _BusinessLayer
{
    public class KullaniciBusiness
    {
        ConnectionBusiness cb = new ConnectionBusiness();

        public List<Kullanici> Listele()
        {
            SqlCommand cmd = new SqlCommand("K_Listele", cb.OpenConnection());
            cmd.CommandType=CommandType.StoredProcedure;
            List<Kullanici> kullanicilar = new List<Kullanici>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kullanicilar.Add(new Kullanici(Convert.ToInt32(dr[0]),dr[1].ToString(), dr[2].ToString(),Convert.ToInt32(dr[3]), Convert.ToInt32(dr[4]), Convert.ToInt32(dr[5])));
            }
            cb.CloseConnection();
            return kullanicilar;
        }
    }
}
