using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentaCarTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>() {
            new Car(1, "Renault", "Clio", 150,false),
            new Car(2, "Ford", "Focus", 250,false),
            new Car(3, "Volkswagen", "Golf", 350,false)
            };

            List<Customer> customer = new List<Customer>() {             
                new Customer(1,"Ahmet","Kaya"),
                new Customer(2,"Salsa","Güneş"),
                new Customer(3,"Ali","Veli"),                     
            };
            List<Rental> rentals = new List<Rental>();
            Rental rental1 = new Rental
            {
                RentalId = 1,
                Car = cars[0],
                Customer = customer[0],
                RentDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(7)
            };
            rental1.Car.Rent();
            rentals.Add(rental1);

            Rental returnedRental = rentals[0];
            returnedRental.Car.Return();
            Console.WriteLine($"{returnedRental.Customer.Name} tarafından kiralanan {returnedRental.Car.Brand} arabası {returnedRental.ReturnDate} tarihinde iade edildi.");

            Console.ReadKey();
        }
    }
}
