using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Yıldırım";
            musteri1.DogumYeri = "Beykoz";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Albayrak";
            musteri2.DogumYeri = "Çaykara";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Göksal";
            musteri3.Soyad = "TAK";
            musteri3.DogumYeri = "Bakırköy";

            Musteri[] musterilistele = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            foreach (var musteriler in musterilistele)
            {
                musteriManager.Listele(musteriler);
            }
            Console.WriteLine("-----------------Liste Sonu--------------------");
            

            Musteri[] musteriekle = new Musteri[] { musteri1, musteri2,musteri3 };
            foreach (var musteriler in musteriekle)
            {
                musteriManager.Ekle(musteriler);
            }
            Console.WriteLine("-----------------Ekleme Sonu--------------------");
            Musteri[] musterisil = new Musteri[] { musteri1};
            foreach (var musteriler in musterisil)
            {
                musteriManager.Sil(musteriler);
            }

            Console.WriteLine("-----------------Silme Sonu--------------------");




        }
    }
}
