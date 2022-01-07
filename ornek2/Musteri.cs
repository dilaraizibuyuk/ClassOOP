using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Musteri
    {
        public string ad;
        public string soyad;
        public int yas;
        public int maas;
        public string cinsiyet;

        public Musteri(string _ad, string _soyad, int _yas, int _maas, string _cinsiyet) //yapıcı metod
        {
            ad = _ad;
            soyad = _soyad;
            yas = _yas;
            maas = _maas;
            cinsiyet=_cinsiyet;

        }
    }
}
