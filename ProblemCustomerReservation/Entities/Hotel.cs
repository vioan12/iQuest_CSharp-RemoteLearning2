using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class Hotel : IEntity
    {
        public int Id { get; private set; }
        public string HotelName { get; private set; }
        public string City { get; private set; }
        public Hotel(int hotelId, string hotelName, string city)
        {
            Id = hotelId;
            HotelName = hotelName;
            City = city;
        }
    }
}
