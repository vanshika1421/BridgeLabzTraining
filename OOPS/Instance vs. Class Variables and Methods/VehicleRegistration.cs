//Problem 3: Vehicle Registration
//Create a Vehicle class to manage vehicle details:
//Instance Variables: ownerName, vehicleType.
//Class Variable: registrationFee(fixed for all vehicles).
//Implement the following methods:
//An instance method DisplayVehicleDetails() to display owner and vehicle details.
//A class method UpdateRegistrationFee() to change the registration fee.


using System;
using System.Collections.Generic;
using System.Text;

namespace Instance_vs._Class_Variables_and_Methods
{
    internal class VehicleRegistration
    {
        string ownerName;
        string vehicleType;
        static int registrationfee = 500;
        public VehicleRegistration(string ownerName, string vehicleType )
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;

        }
        public static int UpdateRegistrationfee()
        {
            return registrationfee+100;
        }
        public void Displaydetails()
        {
            Console.WriteLine($"Vehicle type is {vehicleType}");
            Console.WriteLine($"Owner Name is {ownerName}");
            Console.WriteLine("Registration fee is " + UpdateRegistrationfee());
        }

    }
}
