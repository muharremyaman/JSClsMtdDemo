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
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.adi + " " + musteri.soyadi + " " + musteri.yasi + " " + musteri.Id);
        }
        
    }
}
