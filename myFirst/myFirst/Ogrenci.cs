using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class Ogrenci
    {
        public int ogrenciId { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }

        public void ogrenciListele()
        {
                Console.WriteLine($"Öğrenci ID: {ogrenciId}");
                Console.WriteLine($"Öğrenci Adı: {Adi}");
                Console.WriteLine($"Öğrenci Soyadı: {Soyad}");
        }
    }
}
