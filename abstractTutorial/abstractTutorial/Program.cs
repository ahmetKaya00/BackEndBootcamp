using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5.1);
            Shape rectagle = new Rentagle(2.8,8.2);

            Console.WriteLine("Daire Alanı:" + circle.CalculateArea());
            Console.WriteLine("Dikdörtgen Alanı:" +  rectagle.CalculateArea());

            Console.ReadLine();
        }
    }
}
