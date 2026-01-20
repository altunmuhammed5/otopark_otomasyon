using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace otopark_otomasyon
{
    public class Sofor
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Cinsiyet { get; set; }

        public Sofor(string ad, string soyad, int yas, string cinsiyet)
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            Cinsiyet = cinsiyet;
        }

        public Sofor()
        {
        }
        public override string ToString()
        {
            return "Şoför Adı: "+Ad+" Soyadı: "+Soyad+" Yas: "+Yas+" Cinsiyet: "+Cinsiyet;
        }
    }
}