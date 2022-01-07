using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek5
{
   public class Personel
    {
        string isim, soyisim, unvan = null;
        double maas;
        int izinGunu;
        string ayrac = new string('-', 10);
        public void setPersonelBilgileri(string isim, string soyisim, double maas)
        {
            if (isim.Length > 0 && soyisim.Length > 0)
            {
                if (maas >= 2500)
                {
                    this.isim = isim;
                    this.soyisim = soyisim;
                    this.maas = maas;
                    this.izinGunu = 14;
                    if (maas >= 3000 && maas <= 4000)
                    {
                        this.unvan = "Kıdemli Personel";
                        this.izinGunu = 20;

                    }
                    else if (maas >= 4001 && maas <= 5500)
                    {
                        this.unvan = "Kıdemli+Personel";
                        this.izinGunu = 24;
                    }
                    else if (maas > 5500)
                    {
                        this.unvan = "Uzman Personel";
                        this.izinGunu = 30;
                    }
                    else
                    {
                        this.unvan = "Personel";

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("{0}\n<Personel Oluşturulamadı>\n{1}\n->Personelin maaşı en az 2500 Tl olmalıdır.\n{2}", ayrac, ayrac, ayrac);
                }
            }
        }
        public string getPersonelBilgileri()
        {
            if (unvan != null)

                return ayrac + "\n<Personel Oluşturuldu>\n" + ayrac + "\n->Personel İsmi:" + isim + "\n->Personel Soyismi:" + soyisim + "\n->Personel Maaş:" + maas + "TL\n->Personel Unvanı:" + unvan + "\n->Personel İzin Günü:" + izinGunu + "Gün\n" + ayrac;
            else
                return ayrac + "\n<Personel Oluşturmanız Gerekiyor>\n" + ayrac;
        }
        }
    }