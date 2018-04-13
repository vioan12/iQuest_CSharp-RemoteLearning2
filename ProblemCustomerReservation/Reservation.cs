using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class Reservation
    {
        public DateTime CheckInDate { get; internal set; }
        public DateTime CheckOutDate { get; internal set; }
        public Hotel Hotel { get; private set; }
        public Reservation(Hotel hotel)
        {
            Hotel = hotel;
            CheckInDate = default(DateTime);
            CheckOutDate = default(DateTime);
        }
    }
}
