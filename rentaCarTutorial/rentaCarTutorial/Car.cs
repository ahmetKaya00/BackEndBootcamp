using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentaCarTutorial
{
    internal class Car
    {
        public int carId {  get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal DailyPrice { get; set; }
        public bool IsRented { get; set; }

        public Car(int carId, string brand, string model, decimal dailyPrice, bool ısRented)
        {
            this.carId = carId;
            Brand = brand;
            Model = model;
            DailyPrice = dailyPrice;
            IsRented = false;
        }
        public void Rent()
        {
            IsRented = true;
        }
        public void Return() {

            IsRented = false;
        }

    }
}
