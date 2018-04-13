using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class Hotel
    {
        public string HotelName { get; private set; }
        public string City { get; private set; }
        public Hotel(string hotelName, string city)
        {
            HotelName = hotelName;
            City = city;
        }
    }
}
