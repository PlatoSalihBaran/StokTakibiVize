using System;
using System.Collections.Generic;
using System.Data;
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
            SqlCommand cmd = new SqlCommand("sp_ProductList", cb.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            List<Urun> urunler = new List<Urun>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                urunler.Add(new Urun(dr[0].ToString(), dr[1].ToString(), Convert.ToDecimal(dr[2]), Convert.ToInt32(dr[3])));
            }
            cb.CloseConnection();
            return urunler;
        }

        public void UrunEkle(Urun u)
        {
            SqlCommand cmd = new SqlCommand("U_Ekle", cb.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@U_Adi", u.U_Adi);
            cmd.Parameters.AddWithValue("@U_Barkod", u.U_Barkod);
            cmd.Parameters.AddWithValue("@U_Fiyat", u.U_Fiyat);
            cmd.Parameters.AddWithValue("@U_StokAdet", u.U_StokAdet);
            cmd.ExecuteNonQuery();
            cb.CloseConnection();
        }

        public void StokArttir(Urun u)
        {
            SqlCommand cmd = new SqlCommand("sp_ProductStockUp", cb.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@U_Barkod", u.U_Barkod);
            cmd.ExecuteNonQuery();
            cb.CloseConnection();
        }
        public void StokEksilt(Urun u)
        {
            SqlCommand cmd = new SqlCommand("sp_ProductStockDown", cb.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@U_Barkod", u.U_Barkod);
            cmd.ExecuteNonQuery();
            cb.CloseConnection();
        }

        public void Duzenle(Urun u)
        {
            SqlCommand cmd = new SqlCommand("sp_ProductUpdate", cb.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@U_Barkod", u.U_Barkod);
            cmd.Parameters.AddWithValue("@U_Adi", u.U_Adi);
            cmd.Parameters.AddWithValue("@U_Fiyat", u.U_Fiyat);
            cmd.ExecuteNonQuery();
            cb.CloseConnection();
        }

        public void Sil(Urun u)
        {
            SqlCommand cmd = new SqlCommand("sp_ProductDelete", cb.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@U_Barkod", u.U_Barkod);
            cmd.ExecuteNonQuery();
            cb.CloseConnection();
        }

        public void Ekle(Urun u)
        {
            SqlCommand cmd=new SqlCommand("sp_ProductInsert",cb.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@U_Adi", u.U_Adi);
            cmd.Parameters.AddWithValue("@U_Barkod", u.U_Barkod);
            cmd.Parameters.AddWithValue("@U_Fiyat", u.U_Fiyat);
            cmd.Parameters.AddWithValue("@U_StokAdet", u.U_StokAdet);
            cmd.ExecuteNonQuery();
            cb.CloseConnection();
        }

    }
}
