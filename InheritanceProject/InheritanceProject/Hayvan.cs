using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    internal class Hayvan
    {
        public string Ad {  get; set; }
        public string Yas { get; set; }

        public void beslenme()
        {
            Console.WriteLine($"{Ad}, şuan besleniyor.");
        }
        public void uyuma()
        {
            Console.WriteLine($"{Ad}, şuan uyuyor.");
        }

        public void asiOlma()
        {
            Console.WriteLine($"{Ad}, şuan {Yas} yaşında ve aşı olacak.");
        }
    }
}
