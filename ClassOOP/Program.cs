using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Araba araba1 = new Araba(); //object oluşturma
            //araba1.kapi_sayisi = 4;
            //araba1.araba_rengi = "Siyah";
            //araba1.araba_model = "Range Rover";

            //araba1.kapilariKilitle();
            //araba1.motorCalistir();

            //yapıcı metot kullanma
            Araba araba1 = new Araba(4, "Mini Cooper", "Kırmızı");



            Console.WriteLine("Arabanın kapı sayısı:"+araba1.kapi_sayisi);
            Console.WriteLine("Arabanın rengi:" + araba1.araba_rengi);
            Console.WriteLine("Arabanın modeli:" + araba1.araba_model);

            Console.ReadLine();
        }
    }
}
