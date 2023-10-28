using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentaCarTutorial
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer(int customerId,string name,string surname) {
        
            CustomerId = customerId;
            Name = name;
            Surname = surname;
        }
    }
}
