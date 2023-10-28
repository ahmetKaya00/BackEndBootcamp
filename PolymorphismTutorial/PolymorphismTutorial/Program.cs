using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathHelper mathHelper = new MathHelper();
            MathHelper myDog = new Dog();

            mathHelper.Sound();
            myDog.Sound();

            Console.ReadLine();

        }
    }
}
