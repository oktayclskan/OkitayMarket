using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkitayMarketleri
{
    class Program
    {
        static void Main(string[] args)
        {

            Islem i = new Islem();
            Urun[] urunler;

            double toplam = 0;
            Urun urun = new Urun()
            {
                İsim = "Amasya Elması",
                Fiyat = 14.50,
                Birim = "KG",
                reyon = "Manav",
                stok = 55
            };
            i.Ekle(urun);

            Urun urun1 = new Urun()
            {
                İsim = "Portakal",
                Fiyat = 13,
                Birim = "KG",
                reyon = "Manav",
                stok = 21
            };
            i.Ekle(urun1);

            Urun urun2 = new Urun()
            {
                İsim = "Domates",
                Fiyat = 22.36,
                Birim = "KG",
                reyon = "Manav",
                stok = 70
            };
            i.Ekle(urun2);

            Urun urun3 = new Urun()
            {
                İsim = "Salata",
                Fiyat = 33,
                Birim = "KG",
                reyon = "Manav",
                stok = 120
            };
            i.Ekle(urun3);

            Urun urun4 = new Urun()
            {
                İsim = "Patlıcan",
                Fiyat = 17.50,
                Birim = "KG",
                reyon = "Manav",
                stok = 16
            };
            i.Ekle(urun4);

            Urun urun5 = new Urun()
            {
                İsim = "Kayısı",
                Fiyat = 35,
                Birim = "KG",
                reyon = "Manav",
                stok = 36
            };
            i.Ekle(urun5);

            Urun urun6 = new Urun()
            {
                İsim = "Kola",
                Fiyat = 22,
                Birim = "Şişe",
                reyon = "icecekler",
                stok = 55

            };
            i.Ekle(urun6);
            Urun urun7 = new Urun()
            {
                İsim = "Fanta",
                Fiyat = 19.50,
                Birim = "Şişe",
                reyon = "icecekler",
                stok = 75

            };
            i.Ekle(urun7);
            Urun urun8 = new Urun()
            {
                İsim = "Sprite",
                Fiyat = 25,
                Birim = "Şişe",
                reyon = "icecekler",
                stok = 78

            };
            i.Ekle(new Urun() { İsim = "Ayran", Fiyat = 5, Birim = "Litre", reyon = "icecekler", stok = 69 });
            i.Ekle(urun8);
            Urun urun9 = new Urun()
            {
                İsim = "Kırmızı Et",
                Fiyat = 110,
                Birim = "KG",
                reyon = "Et Ürünleri",
                stok = 12

            };
            i.Ekle(urun9);
            Urun urun10 = new Urun()
            {
                İsim = "Tavuk",
                Fiyat = 55,
                Birim = "KG",
                reyon = "Et Ürünleri",
                stok = 32

            };
            i.Ekle(urun10);
            urunler = i.UrunleriGetir();


            Reyon Manav = new Reyon()
            {
                tür = "Manav"
            };
            i.reyonEkle(Manav);

            Reyon icecekler = new Reyon()
            {
                tür = "icecekler"
            };
            i.reyonEkle(icecekler);

            Reyon Gıda = new Reyon()
            {
                tür = "Et Ürünleri"
            };
            i.reyonEkle(Gıda);




            Console.WriteLine("Okitay Markete Hoşgeldiniz");
            Console.WriteLine("**************************");


            string secenek = "e";
            while (secenek == "e")
            {
                i.reyonYazdır();

                Console.WriteLine("Lütfen Reyon Numarasını Giriniz");
                int rno = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                i.Reyonici(rno);

                Console.WriteLine("Almak İstediğiniz Ürün Numarasını Giriniz");
                int uno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("kaç " + urunler[uno - 1].Birim + " " + urunler[uno - 1].İsim + " Alacaksınız");
                int adet = Convert.ToInt32(Console.ReadLine());
                if (adet < urunler[uno - 1].stok)
                {
                    toplam += i.satinAl(uno, adet) * adet;

                    Console.WriteLine("Toplam Tutar = "+toplam + " TL");


                }
                else
                {
                    Console.WriteLine("Stok Yetersiz");
                }
                Console.WriteLine("Alişverişe Devam Edilsinmi e/h");
                secenek = Console.ReadLine();
                Console.Clear();



            }



        }
    }
}
