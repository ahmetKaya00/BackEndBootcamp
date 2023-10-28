using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationTutorial
{
    internal class Student : Person
    {
        public void DisplayFields()
        {
            Console.WriteLine($"PublicField: {PublicField}");
            //Console.WriteLine($"PrivateField: {PrivateField}");
            Console.WriteLine($"ProtectedField: {ProtectedField}");
            Console.WriteLine($"InternalField: {InternalField}");
            Console.WriteLine($"PerotectedInternalField: {ProtectedInternalField}");
        }
    }
}
