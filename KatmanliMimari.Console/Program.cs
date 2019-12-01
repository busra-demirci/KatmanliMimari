using KatmanliMimari.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci
            {
                Ad = "Ali",
                Soyad = "Yılmaz",
                Bolum = "Bilgisayar Müh."
            };

            Egitmen egitmen1 = new Egitmen
            {
                Ad = "Bülent",
                Soyad = "Başyurt",
                Brans = "Yazılım",
                Maas = 5000,
                Mezuniyet="Bilgisayar Müh."
            };

            ogrenci1.NotHesapla();
        }
    }
}
