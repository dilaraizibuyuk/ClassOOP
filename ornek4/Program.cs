using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control = true;
            Ogrenci ogrenci1 = new Ogrenci(963,"Tom","Hardy",78,60,80,"Standford University");
            Console.WriteLine("Öğrenci Portalına Hoşgeldiniz"+"\n"+"Yapmak istediğiniz işlemi seçiniz.");
            
            while (control)
            {
                islemlerigoster();
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrencibilgilerinigoster();
                        break;

                    case "2":
                        double ogrenciortalama = ogrenci1.ogrencinotunuhesapla();
                        Console.WriteLine("Öğrencinin Ortalaması"+ogrenciortalama);
                        break;

                    case "3":
                        ogrenci1.okulgetir();
                        break;

                    case "4":
                        control = false;
                        break;


                }
            }
           

        }
        static void islemlerigoster()
        {
            Console.WriteLine("1: Öğrencinin Bilgilerini Göster");
            Console.WriteLine("2: Öğrencinin Ortalamasını Göster");
            Console.WriteLine("3: Öğrencinin Okulunu Göster");
            Console.WriteLine("4: Çıkış Yap");
        }
    }
}
