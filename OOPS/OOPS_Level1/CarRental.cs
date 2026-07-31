//using System.Xml.Linq;

//Car Rental System
//Create a CarRental class with attributes customerName, carModel, and rentalDays.
//Add constructors to initialize the rental details and calculate total cost.


using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class CarRental
    {
        String carName, carModel;
        int rentalDays;
        int totalCost;
      public CarRental(string carName, string carModel , int rentalDays)
        {
            this.carName = carName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
            this.totalPrice();
        }
        public int totalPrice()
        {
            totalCost = rentalDays * 700;
            return totalCost;
        }
        public void showDetails()
        {
            Console.WriteLine(totalPrice());
        }
    }
}
