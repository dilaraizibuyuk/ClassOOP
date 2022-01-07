using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOOP
{
    public class Araba //class tanımlama
    {   //property tanımlama
        public int kapi_sayisi;
        public string araba_model;
        public string araba_rengi;
        //public Araba() //method tanımlama. method ve classın adı aynı olmak zorunda
        //{
        //    Console.WriteLine("Araba sınıfının yapıcı metodu çalıştı");
        //}

        //public void motorCalistir()
        //{
        //    Console.WriteLine("Motor Çalışıyor");
        //}

        //public void kapilariKilitle()
        //{
        //    Console.WriteLine("Kapılar kilitleniyor");
        //}
        
        public Araba(int _kapisayisi,string _arabamodel,string _arabarenk) //yapıcı metod
        {
            kapi_sayisi = _kapisayisi;
            araba_model = _arabamodel;
            araba_rengi = _arabarenk;
        }
    }
}
