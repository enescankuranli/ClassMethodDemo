using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 01;
            musteri1.Ad = "Enes Can";
            musteri1.Soyad = "Kuranlı";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 02;
            musteri2.Ad = "Buğra";
            musteri2.Soyad = "Demirer";


            Musteri musteri3 = new Musteri();
            musteri3.Id = 03;
            musteri3.Ad = "İrem";
            musteri3.Soyad = "Yörük";

            


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.Id + " " + Musteri.Ad + " " + Musteri.Soyad);
            }
            Console.WriteLine("****************Listelenenler*****************");
            musterimanager musteri = new musterimanager();
            musteri.Ekle(musteri1);
            musteri.Ekle(musteri2);
            musteri.Ekle(musteri3);
            

            Console.WriteLine("****************Silinenler***************");
            



        }
    }
}
