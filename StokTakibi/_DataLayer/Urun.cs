﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer
{
    public class Urun
    {

        public Urun(int U_ID, string U_Adi, string U_Barkod, decimal U_Fiyat, int U_StokAdet)
        {
            this.U_Adi = U_Adi;
            this.U_Barkod = U_Barkod;
            this.U_Fiyat = U_Fiyat;
            this.U_StokAdet = U_StokAdet;
        }

        public int U_ID { get; set; }
        public string U_Adi { get; set; }
        public string  U_Barkod { get; set; }
        public decimal U_Fiyat { get; set; }
        public int U_StokAdet { get; set; }
    }
}
