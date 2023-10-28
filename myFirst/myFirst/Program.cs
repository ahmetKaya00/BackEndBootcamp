using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OgrenciYonetimSistemi ogrenciYonetim = new OgrenciYonetimSistemi();
            while (true)
            {
                Console.WriteLine("Öğrenci Yönetim Sistemi");
                Console.WriteLine("1- Öğrenci Ekle");
                Console.WriteLine("2- Öğrenci Listele");
                Console.WriteLine("3- Çıkış");
                Console.Write("Lütfen bir seçim yapınız:");

                int secim;
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        ogrenciYonetim.ogrenciEkle();
                        break;
                    case 2:
                        ogrenciYonetim.ogrenciListeleme();              
                        break;
                        case 3: Environment.Exit(0);break;
                }

            }
        }
    }
}
