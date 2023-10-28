using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class OgrenciYonetimSistemi
    {
        private List<Ogrenci> ogrencis = new List<Ogrenci>();

        public void ogrenciEkle()
        {
            Ogrenci ogrenci = new Ogrenci();
            Console.Write("Öğrenci ID:");
            ogrenci.ogrenciId = int.Parse(Console.ReadLine());
            Console.Write("Öğrenci Adı:");
            ogrenci.Adi=Console.ReadLine();
            Console.Write("Öğrenci Soyadı:");
            ogrenci.Soyad =Console.ReadLine();

            ogrencis.Add(ogrenci);
            Console.WriteLine("Ekleme başarılı!");
        }
        public void ogrenciListeleme()
        {
            Console.WriteLine("Tüm Öğrenciler:");
            foreach(var ogrenci in ogrencis)
            {
                ogrenci.ogrenciListele();
            }
        }
    }
}
