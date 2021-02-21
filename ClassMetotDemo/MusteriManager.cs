using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musteri Listelendi :" + musteri.Ad + " " + musteri.Soyad + " " + musteri.DogumYeri);
            
        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi :" + musteri.Ad + " " + musteri.Soyad +" " + musteri.DogumYeri);
           
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi :" + musteri.Ad + " " + musteri.Soyad + " " + musteri.DogumYeri);
            
        }
    }
}
