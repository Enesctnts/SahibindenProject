using Business.Concrete;
using DataAccess.Entity;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Id = 1;
            kullanici.AdSoyad = "Enes Çetintaş";
            kullanici.Telefon = "05458817135";

            Kullanici kullanici2 = new Kullanici();
            kullanici2.Id = 2;
            kullanici2.AdSoyad = "Apdullah Network";
            kullanici2.Telefon = "0353053053";

            Kullanici kullanici3 = new Kullanici();
            kullanici3.Id = 2;
            kullanici3.AdSoyad = "Uğur Network";
            kullanici3.Telefon = "0354153052";

            Ilan ilan = new Ilan();
            ilan.Id = 2;
            ilan.IlanNo = 321321;
            ilan.Baslik = "Şok Fiyatlar";
            ilan.IlanTarihi = DateTime.Now;
            ilan.Fiyat = 571;
            ilan.Satici = kullanici2;

            Ilan ilan2 = new Ilan();
            ilan2.Id = 1;
            ilan2.IlanNo = 123123;
            ilan2.Baslik = "Çılgın Kazanç";
            ilan2.IlanTarihi = DateTime.Now;
            ilan2.Fiyat = 750;
            ilan2.Satici = kullanici;

            Ilan ilan3 = new Ilan();
            ilan3.Id = 3;
            ilan3.IlanNo = 521321;
            ilan3.Baslik = "İndirimler";
            ilan3.IlanTarihi = DateTime.Now;
            ilan3.Fiyat = 500;
            ilan3.Satici = kullanici3;

            DizustuManager dizustuManager = new DizustuManager(new DizustuDal(), new KategoryManager(new KategoriDal()));
            Dizustu dizustu = new Dizustu();
            dizustu.Id = 1;
            dizustu.IlanNo = 1;
            dizustu.IlanTarihi = DateTime.Now;
            dizustu.HDD = 12;
            dizustu.SSD = 1024;
            dizustu.Marka = "Hp";
            dizustu.Satici = kullanici;
            dizustu.Fiyat = 123;
            dizustu.Bellek = "amdd";
            dizustu.Agirlik = 12356;
            dizustu.EkranBoyutu = "18 inc";
            dizustu.EthernetVarMi = true;
            dizustu.WifiVarMi = true;
            dizustu.kategori = dizustuManager.KategoriBul(1);
            dizustuManager.Kaydet(dizustu);

            Dizustu dizustu2 = new Dizustu();
            dizustu2.Id = 2;
            dizustu2.IlanNo = 2;
            dizustu2.IlanTarihi = DateTime.Now;
            dizustu2.HDD = 2132;
            dizustu2.SSD = 1024;
            dizustu2.Marka = "Acer";
            dizustu2.Satici = kullanici2;
            dizustu2.Fiyat = 123;
            dizustu2.Bellek = "asas";
            dizustu2.Agirlik = 12356;
            dizustu2.EkranBoyutu = "15 inc";
            dizustu2.EthernetVarMi = true;
            dizustu2.WifiVarMi = false;
            dizustu2.kategori = dizustuManager.KategoriBul(2);
            dizustuManager.Kaydet(dizustu2);

            Dizustu dizustu3 = new Dizustu();
            dizustu3.Id = 3;
            dizustu3.IlanNo = 3;
            dizustu3.IlanTarihi = DateTime.Now;
            dizustu3.HDD = 3025;
            dizustu3.SSD = 1024;
            dizustu3.Marka = "Casper";
            dizustu3.Satici = kullanici3;
            dizustu3.Fiyat = 1425;
            dizustu3.Bellek = "asad";
            dizustu3.Agirlik = 8586;
            dizustu3.EkranBoyutu = "10 inc";
            dizustu3.EthernetVarMi = false;
            dizustu3.WifiVarMi = true;
            dizustu3.kategori = dizustuManager.KategoriBul(2);
            dizustuManager.Kaydet(dizustu3);





            IlanManager ilanManager = new IlanManager(new IlanDal());
            ilanManager.Kaydet(ilan);
            ilanManager.Kaydet(ilan2);
            ilanManager.Kaydet(ilan3);

            //foreach (var item in ilanManager.Sirala())
            //{
            //    Console.WriteLine(item.Satici.Adsoyad + " " + item.IlanNo);
            //}

            foreach (var item in dizustuManager.Siralama())
            {
                Console.WriteLine(item.kategori.CategoryName + " " + item.Marka);
            }

            Console.ReadLine();

        }
    }
}

