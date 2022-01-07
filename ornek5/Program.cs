using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek5
{
    class Program
    {
        static void Main(string[] args)
        {

            Personel yasin = new Personel();
            Personel mertkan = new Personel();
            Personel sait = new Personel();
            Personel mirayet = new Personel();
            yasin.setPersonelBilgileri("Yasin", "Göktepe", 5000);
            mertkan.setPersonelBilgileri("Mertkan", "İskurt", 6000);
            sait.setPersonelBilgileri("Sait", "Kayar", 8000);
            mirayet.setPersonelBilgileri("Mirayet", "Müftüoğlu", 4001);

            Console.WriteLine(yasin.getPersonelBilgileri());
            Console.WriteLine(mertkan.getPersonelBilgileri());
            Console.WriteLine(sait.getPersonelBilgileri());
            Console.WriteLine(mirayet.getPersonelBilgileri());
            Console.ReadLine();


        }
    }
}
