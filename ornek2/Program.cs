using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Program
    {
        static void Main(string[] args)
        {   //müşteri olacak bilgilerini sistem gösterecek ad soyad maaş yaş cinsiyer

            Musteri musteri1 = new Musteri("Dilara", "İzibüyük", 7000,22,"Kadın");

            Console.WriteLine("Müşterinin adı:"+musteri1.ad);
            Console.WriteLine("Müşterinin soyadı:"+ musteri1.soyad);
            Console.WriteLine("Müşterinin maaşı:"+ musteri1.maas);
            Console.WriteLine("Müşterinin yaşı:"+ musteri1.yas);
            Console.WriteLine("Müşterinin cinsiyeti:"+ musteri1.cinsiyet);
            Console.ReadKey();
        }
    }
}
