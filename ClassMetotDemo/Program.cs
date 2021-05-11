using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.adi = "Mehmet";
            musteri1.soyadi = "Yilmaz";
            musteri1.Id = 1;
            musteri1.yasi = 35;
            
            Musteri musteri2 = new Musteri();
            musteri2.adi = "Ayşe";
            musteri2.soyadi = "Dönmez";
            musteri2.Id = 2;
            musteri2.yasi = 27;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri1);

        }
    }
}
