using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class musterimanager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + "  " + "Eklenmiştir");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + "Silinmiştir");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler Listelendi");








        }
    }
}