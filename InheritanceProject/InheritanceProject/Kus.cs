using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    internal class Kus : Hayvan
    {
        public void ucmak()
        {
            Console.WriteLine($"{Ad}, şuan uçuyor");
        }
    }
}
