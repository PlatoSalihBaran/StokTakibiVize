using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _DataLayer;
namespace _BusinessLayer
{
    public class UrunBusiness
    {
        ConnectionBusiness cb = new ConnectionBusiness();

        public List<Urun> Listele()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Urunler",cb.OpenConnection());
            List<Urun> urunler = new List<Urun>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                urunler.Add(new Urun(Convert.ToInt32(dr[0]),dr[1].ToString(),dr[2].ToString(),Convert.ToDecimal(dr[3]),Convert.ToInt32(dr[4])));
            }
            cb.CloseConnection();
            return urunler;
        }
    }
}
