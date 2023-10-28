using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationTutorial
{
    internal class Person
    {
        public int PublicField; // Her yerden erişilebilir.
        private int PrivateField; // Sadece bu sınıf içerisinde erişilebilir.
        protected int ProtectedField; //Alt sınıflardan erişilebilir.
        internal int InternalField; // sadece aynı derleme içerisinde erişilebilir.
        protected internal int ProtectedInternalField; //Aynı derleme ve alt sınıflardan erişilebilir

        public void BaseDisplayFields()
        {
            Console.WriteLine($"PublicField: {PublicField}");
            Console.WriteLine($"PrivateField: {PrivateField}");
            Console.WriteLine($"ProtectedField: {ProtectedField}");
            Console.WriteLine($"InternalField: {InternalField}");
            Console.WriteLine($"PerotectedInternalField: {ProtectedInternalField}");
        }
    }
}
