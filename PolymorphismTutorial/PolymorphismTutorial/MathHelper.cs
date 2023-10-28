using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTutorial
{
    internal class MathHelper
    {
        public virtual void Sound()
        {
            Console.WriteLine("Hayvan Sesi");
        }
    }
}
