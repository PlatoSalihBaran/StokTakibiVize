using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer
{
    public class Kullanici
    {
        //Kullanici(Convert.ToString)
        public Kullanici(int K_ID, string K_Adi,string Y_Adi, int Silme, int Guncelleme,int K_Ekleme)
        {
            this.K_ID = K_ID;
            this.K_Adi = K_Adi;
            this.K_Yetki = K_Yetki;
            this.K_Sifre = K_Sifre;
            this.Y_ID = Y_ID;
            this.Y_Adi = Y_Adi;
            this.Silme = Silme;
            this.Guncelleme = Guncelleme;
            this.K_Ekleme = K_Ekleme;
        }

        public int K_ID { get; set; }
        public string K_Adi { get; set; }
        public int K_Yetki { get; set; }
        public string K_Sifre { get; set; }
        public int Y_ID { get; set; }
        public string Y_Adi { get; set; }
        public int Silme { get; set; }
        public int Guncelleme { get; set; }
        public int K_Ekleme { get; set; }

    }
}
