//using System.Xml.Linq;

//Hotel Booking System
//Create a HotelBooking class with attributes guestName, roomType, and nights.
//Use default, parameterized, and copy constructors to initialize bookings.


using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class HotelBookingSystem
    {
        String guestName;
        string roomTypes;
        int noOfNights;
       public HotelBookingSystem()
        {
            guestName = "Anonymous";
            roomTypes = "Single room";
            noOfNights = 1;
        }

       public HotelBookingSystem(String guestName, String roomTypes , int noOfNights)
        {
            this.guestName = guestName;
            this.roomTypes = roomTypes;
            this.noOfNights = noOfNights;
        }
        public HotelBookingSystem(HotelBookingSystem other)
        {
            this.guestName = other.guestName;
            this.roomTypes = other.roomTypes;
            this.noOfNights = other.noOfNights;
        }
        public void displayDetails()
        {
            Console.WriteLine("Guest Name is " + guestName);
            Console.WriteLine("Room type is " + roomTypes);
            Console.WriteLine("No of Nights " + noOfNights);
        }
    }
}
