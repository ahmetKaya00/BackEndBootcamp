using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentaCarTutorial
{
    internal class Rental
    {
        public int RentalId { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set;}


    }
}
