using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.adi+"   isimli musteri Eklendi!");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.adi+"   isimli musteri Silindi!");
        }
        public void Listele(Musteri musteri1,Musteri musteri2)
        {
            Console.WriteLine(musteri1.adi + " " + musteri1.soyadi + " " + musteri1.yasi + " " + musteri1.Id);
            Console.WriteLine(musteri2.adi + " " + musteri2.soyadi + " " + musteri2.yasi + " " + musteri2.Id);
        }
        
    }
}
