using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("BaseClass:");
            person.BaseDisplayFields();

            Student student = new Student();
            Console.WriteLine("Student Class:");
            student.PublicField = 5;
            student.ProtectedInternalField = 5;
            student.DisplayFields();
            

            Console.ReadLine();
            
        }
    }
}
