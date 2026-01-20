using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace otopark_otomasyon
{
    public class Otomobil
    {
        public Otomobil()
        {
        }
        public int islemno { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Yakit { get; set; }
        public double  Motor { get; set; }
        public int saat { get; set; }
        public Sofor Soforbilgi { get; set; }

        private int parkucret;
      
        public Otomobil(string plaka, string marka, string model, string yakit, double motor,int islemno,int saat)
        {
            Plaka = plaka;
            Marka = marka;
            Model = model;
            Yakit = yakit;
            Motor = motor;
            islemno = this.islemno;
            saat = this.saat;
        }

        public override string ToString()
        {
            return "İşlem no:"+islemno+Soforbilgi.ToString() + " Araç Marka: " + Marka + " Model: " + Model +
                "Yakit tipi: " + Yakit + " Motor Gücü: " + Motor+" Otopark ücreti = "+parkucret;
        }
        public void parkucrethesapla()
        {
            parkucret = saat * 85;
        }
        public void indirimyap(int oran)
        {
            parkucret = parkucret - (parkucret * oran / 100);
        }
    }
}