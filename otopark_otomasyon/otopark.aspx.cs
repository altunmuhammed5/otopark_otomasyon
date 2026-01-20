using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace otopark_otomasyon
{
    public partial class otopark : System.Web.UI.Page
    {
        Dictionary<int, Otomobil> Oto = new Dictionary<int, Otomobil>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void aracekle_btn_Click(object sender, EventArgs e)
        {
           
            while(true)
            {
                aracekle();
                int cv = Convert.ToInt32(Interaction.MsgBox("Devam edecek misiniz?", MsgBoxStyle.YesNo));
                if (cv == 7) break;
                
            }//while

            byte secim=Convert.ToByte( Interaction.InputBox("1-Tüm araçları listele \n2-İşlem Numarasına göre ara \n3-Yeni araç ekle \n4-İşlem numarasına göre girilen oranla indirim yap"));

            switch(secim)
            {
                case 1:
                    araclistele();
                    break;
                case 2:
                    int ara = Convert.ToInt32(Interaction.InputBox("İşlem numarasını girin"));
                    ListBox1.Items.Add(Oto[ara].ToString());
                    break;
                case 3:
                    aracekle();
                    araclistele();
                    break;
                case 4:
                    ListBox1.Items.Add("Kayıtlar");
                    araclistele();
                    int isno = Convert.ToInt32(Interaction.InputBox("İndirim yapmak istediğiniz işlem numarasını girin"));
                    int oran = Convert.ToInt32(Interaction.InputBox("İndirim oranını giriniz."));
                    Oto[isno].indirimyap(oran);
                    ListBox1.Items.Add("Güncel indirimli araç bilgisi");
                    ListBox1.Items.Add(Oto[isno].ToString());

                    break;
                default:
                    Interaction.MsgBox("Yanlış seçim!"); 
                    break;
            }
        }

       
        void araclistele()
        {

            foreach (var x in Oto.Values)
            {
                ListBox1.Items.Add(x.ToString());
            }
        }
        void aracekle()
        {

            Otomobil otonesne = new Otomobil() {
            islemno = Convert.ToInt32(Interaction.InputBox("İşlem numarasını girin.")),
           Plaka = Interaction.InputBox("Araç plakasını girin"),
            saat = Convert.ToInt32(Interaction.InputBox("Kaç saat kalacak?")),
            Marka = Interaction.InputBox("Araç Markasını girin"),
           Model = Interaction.InputBox("Araç Modelini girin"),
            Motor = Convert.ToDouble(Interaction.InputBox("Aracın motor gücünü girin")),
            Yakit = Interaction.InputBox("Araç yakıt tipini girin")
        };

            Sofor sofornesne = new Sofor() {

                Ad = Interaction.InputBox("Şoför ismi girin"),
            Soyad = Interaction.InputBox("Şoför soyadını girin"),
            Cinsiyet = Interaction.InputBox("Şoförün cinsiyetini girin"),
            Yas = Convert.ToInt32(Interaction.InputBox("Şoför yaşını girin"))
            
            };


            otonesne.parkucrethesapla();
            otonesne.Soforbilgi = sofornesne;
            Oto.Add(otonesne.islemno, otonesne);

        }


    }
}