using System;
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ecrin";
            musteri1.Soyad = "Algın";
            musteri1.Id = 1;
            musteri1.MusNo = 123;
            musteri1.TcNo = "12345";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Semih";
            musteri2.Soyad = "Algın";
            musteri2.Id = 2;
            musteri2.MusNo = 124;
            musteri2.TcNo = "12346";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Tuna";
            musteri3.Soyad = "Kaya";
            musteri3.Id = 3;
            musteri3.MusNo = 125;
            musteri3.TcNo = "12347";

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("1- Ekleme");
            Console.WriteLine("2- Listele");
            Console.WriteLine("3- Silme");
            Console.Write("Hangi işlemi yapmak istiyorsunuz? :");
            int cevap = Convert.ToInt32(Console.ReadLine());

                switch (cevap)
                {
                    case 1:
                        musteriManager.Ekle(musteri1);
                        musteriManager.Ekle(musteri2);
                        musteriManager.Ekle(musteri3);
                        break;
                    case 2:
                        musteriManager.Listele(musteri1);
                        musteriManager.Listele(musteri2);
                        musteriManager.Listele(musteri3);
                        break;
                    case 3:
                        musteriManager.Silme(musteri1);
                        musteriManager.Silme(musteri2);
                        musteriManager.Silme(musteri3);
                        break;
                    default:
                        Console.WriteLine("Yanlış giriş. Çıkış yapılıyor..");
                        Environment.Exit(0);
                        break;
                }









        }
    }
}