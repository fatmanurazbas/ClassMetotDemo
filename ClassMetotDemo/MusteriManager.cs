using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("{0} adlı müşteri eklendi.", musteri.Ad);
            Console.WriteLine("------------------");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşterinin:");
            Console.WriteLine("Ad: {0}", musteri.Ad);
            Console.WriteLine("Soyad: {0}", musteri.Soyad);
            Console.WriteLine("Id: {0}", musteri.Id);
            Console.WriteLine("Müşteri No: {0}", musteri.MusNo);
            Console.WriteLine("Tc No: {0}", musteri.TcNo);
            Console.WriteLine(musteri + " listelendi.");
            Console.WriteLine("------------------");
        }

        public void Silme(Musteri musteri)
        {
            Console.Clear();
            Console.WriteLine(musteri + " müşterisi silindi.");
            Console.WriteLine("------------------");
        }
    }
}
