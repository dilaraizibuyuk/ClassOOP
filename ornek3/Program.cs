using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek3
{
    class Program
    {
        static void Main(string[] args)
        {   //kutu tanımla hacmini hesaplat genişlik,yükseklik,derinlik olacak 3 tane kutu olacak
            Kutu kutu1 = new Kutu();
            kutu1.SetGenislik(5);
            kutu1.SetYukseklik(8);
            kutu1.SetDerinlik(7);
            kutu1.hacimhesapla();

            //2. kutu 
            Kutu kutu2 = new Kutu();
            kutu2.SetGenislik(10);
            kutu2.SetYukseklik(5);
            kutu2.SetDerinlik(9);
            kutu2.hacimhesapla();

            //3. kutu
            Kutu kutu3 = new Kutu();
            kutu3.hacimhesapla();
            Console.ReadKey();
        }
    }
}
