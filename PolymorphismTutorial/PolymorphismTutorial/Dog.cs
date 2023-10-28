using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTutorial
{
    internal class Dog : MathHelper
    {
        public override void Sound()
        {
            Console.WriteLine("Hav, hav!");
        }
    }
}
