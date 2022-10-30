using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkitayMarketleri
{
    public class Islem
    {
        Urun[] urunler;

        public Islem()
        {
            urunler = new Urun[0];
        }
        public void Ekle(Urun eleman)
        {
            Urun[] gecici = new Urun[urunler.Length + 1];
            Array.Copy(urunler, gecici, urunler.Length);
            gecici[gecici.Length - 1] = eleman;
            urunler = gecici;
        }
        public void urunYazdır()
        {
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine((i + 1) + ".) 1 " + urunler[i].Birim + " " + urunler[i].İsim + " Fiyatı = " + urunler[i].Fiyat +   " TL "+" Stok Adedi = " + urunler[i].stok);
                Console.WriteLine("     ");
            }
        }

        Reyon[] reyonlar = new Reyon[0];
        public void reyonEkle(Reyon sınıf)
        {

            Reyon[] gecici = new Reyon[reyonlar.Length + 1];
            Array.Copy(reyonlar, gecici, reyonlar.Length);
            gecici[gecici.Length - 1] = sınıf;
            reyonlar = gecici;
        }
        public void reyonYazdır()
        {
            for (int i = 0; i < reyonlar.Length; i++)
            {
                Console.WriteLine((i + 1) + ".) " + reyonlar[i].tür);
                Console.WriteLine(" ");
            }
        }
        public void Reyonici(int rici)
        {
            for (int i = 0; i < reyonlar.Length; i++)
            {
                if (rici == i + 1)
                {
                    for (int j = 0; j < urunler.Length; j++)
                    {
                        if (reyonlar[i].tür == urunler[j].reyon)
                        {
                            Console.WriteLine((j+1)+ ".) " + urunler[j].İsim +" "+ urunler[j].Birim +" "+ urunler[j].Fiyat +" TL " +" Stok = " + urunler[j].stok);
                            Console.WriteLine("");
                        }
                    }
                }

            }
        }


        public Urun[] UrunleriGetir()
        {
            return urunler;
        }
        public double satinAl(int urunno, int adet)
        {
            double fiyat = 0;
            
                fiyat = urunler[urunno - 1].Fiyat;
            
            return fiyat;
        }
       
    }
}
