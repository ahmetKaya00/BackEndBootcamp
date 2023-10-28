using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banka Hesap Uygulaması");
            Console.Write("Tasarruf Hesabı Numaranızı Giriniz:");
            string tasarrufHesapNumarasi = Console.ReadLine();
            Console.Write("Başlangıç Bakiyesi:");
            decimal tasarrufBaslangic = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Vadesiz Hesabı Numaranızı Giriniz:");
            string vadesizHesapNumarasi = Console.ReadLine();
            Console.Write("Başlangıç Bakiyesi:");
            decimal vadesizBaslangic = Convert.ToDecimal(Console.ReadLine());

            Hesap tasarrufHesabi = new TasarrufHesabi(tasarrufHesapNumarasi, tasarrufBaslangic);
            Hesap vadesizHesabi = new VadesizHesap(vadesizHesapNumarasi, vadesizBaslangic);

            Console.Write("Tasarruf hesabına para yatırmak için miktar girin:");
            decimal yatirilanMiktar1 = Convert.ToDecimal(Console.ReadLine());
            tasarrufHesabi.ParaYatir(yatirilanMiktar1);

            Console.Write("Tasarruf hesabından para çekmek için miktar girin:");
            decimal cekilenMiktar1 = Convert.ToDecimal(Console.ReadLine());
            tasarrufHesabi.ParaCek(cekilenMiktar1);

            Console.Write("Vadesiz hesabına para yatırmak için miktar girin:");
            decimal yatirilanMiktar2 = Convert.ToDecimal(Console.ReadLine());
            vadesizHesabi.ParaYatir(yatirilanMiktar2);

            Console.Write("Vadesiz hesabından para çekmek için miktar girin:");
            decimal cekilenMiktar2 = Convert.ToDecimal(Console.ReadLine());
            vadesizHesabi.ParaCek(cekilenMiktar2);

            Console.WriteLine("Hesap Bilgileri:");
            tasarrufHesabi.HesapBilgileriniGoster();
            vadesizHesabi.HesapBilgileriniGoster();

            Console.ReadLine();
        }
    }
}
