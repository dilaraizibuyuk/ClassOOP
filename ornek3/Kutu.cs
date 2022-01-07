using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek3
{
    public class Kutu
    {
        double genislik;
        double yukseklik;
        double derinlik;
        

        public Kutu()
        {
            Console.WriteLine("Kutu oluşuyor");
            genislik = 6;
            yukseklik = 4;
            derinlik = 7;
        }
        ~Kutu() //yıkıcı metot
        {
            Console.WriteLine("Kutu nesnesi kaldırılıyor.");
            Console.ReadKey();




        }
        public void SetDerinlik(double d)
        {
            derinlik = d;
        }
        public void SetGenislik(double g)
        {
            genislik = g;
        }

        public void SetYukseklik(double y)
        {
            yukseklik = y;
        }
        public void hacimhesapla()
        {
            double hacim = derinlik * yukseklik * genislik;
            Console.WriteLine("Hacim: {0}",hacim);
        }

        
       
    }
}
