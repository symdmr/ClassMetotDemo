using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 001;
            musteri1.KimlikNo = "123456";
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Yılmaz";
            musteri1.KayitYili = 2002;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 002;
            musteri2.KimlikNo = "123457";
            musteri2.Adi = "Ali";
            musteri2.Soyadi = "Geyik";
            musteri2.KayitYili = 2000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 003;
            musteri3.KimlikNo = "123458";
            musteri3.Adi = "Şeyma";
            musteri3.Soyadi = "Demir";
            musteri3.KayitYili = 2017;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 003;
            musteri4.KimlikNo = "123459";
            musteri4.Adi = "Tuğba";
            musteri4.Soyadi = "Küçük";
            musteri4.KayitYili = 2015;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();

            //Müşteri Listeleme

            foreach (var x in musteriler)
            {
                Console.WriteLine("---------------------------Müşteri Listelendi------------------------------------------");
                Console.WriteLine("Müşteri ID: "+ x.Id);
                Console.WriteLine("Müşteri Adı Soyadı: "+ x.Adi+" " +x.Soyadi);
                Console.WriteLine("Müşterinin hesap açtığı yıl: "+x.KayitYili);
               
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //Müşteri Ekleme
            Console.WriteLine("---------------------------------- Müşteri Eklendi----------------------------------------");
            musteriManager.Ekle(musteri2);

            //Müşteri Silme
            Console.WriteLine("---------------------------------- Müşteri Silindi----------------------------------------");
            musteriManager.Sil(musteri3);


        }  
    }
}
