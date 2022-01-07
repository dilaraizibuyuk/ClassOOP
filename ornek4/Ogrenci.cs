using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
     class Ogrenci
    {
        private int ogr_no;
        private string ad;
        private string soyad;
        private int vize1;
        private int vize2;
        private int final;
        private string okul_adi;
        //alt+enter otomatik yapıcı metot oluşturur.
        public Ogrenci(int _ogr_no, string _ad,string _soyad, int _vize1,int _vize2,int _final, string _okul_adi)
        {
            ogr_no = _ogr_no;
            ad = _ad;
            soyad = _soyad;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final; 
            okul_adi = _okul_adi;

        }

        public void ogrencibilgilerinigoster()
        {
            Console.WriteLine("Öğrenci Numarası:"+ogr_no);
            Console.WriteLine("Öğrenci Adı:"+ ad);
            Console.WriteLine("Öğrenci Soyadı:"+ soyad);
            Console.WriteLine("Öğrencinin Vize1 Notu:"+ vize1);
            Console.WriteLine("Öğrencinin Vize2 Notu:"+ vize2);
            Console.WriteLine("Öğrencinin Final Notu:"+ final);
            Console.WriteLine("Öğrenci Okul Adı:" + okul_adi);


        }
        public double ogrencinotunuhesapla()
        {
             double ortalama = ((vize1 * 0.2) + (vize2 * 0.2) + (final * 0.6));
            return ortalama;
        }

        public void okulgetir()
        {
            Console.WriteLine("Öğrencinin okulunun adı:"+okul_adi);
        }
    }

   
}
