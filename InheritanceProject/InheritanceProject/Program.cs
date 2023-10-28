using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan();
            hayvan.Ad = "Tekir";
            hayvan.Yas = "3";
            hayvan.beslenme();

            Kus kus = new Kus();
            kus.Ad = "Civciv";
            kus.Yas = "3";
            kus.ucmak();

            Kedi kedi = new Kedi();
            kedi.Ad = "Yakup";
            kedi.miyav();

            Console.ReadLine();
        }
    }
}
