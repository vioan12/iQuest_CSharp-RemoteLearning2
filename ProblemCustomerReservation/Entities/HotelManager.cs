using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class HotelManager
    {
        public Hotel Hotel { get; private set; }
        public HotelManager(Hotel hotel)
        {
            Hotel = hotel;
        }
        public Reservation CreateReservation(int customerId, DateTime checkInDate)
        {
            Reservation reservation = new Reservation();
            reservation.CustomerId = customerId;
            reservation.CheckInDate = checkInDate;
            reservation.Hotel = Hotel;
            return reservation;
        }
        public bool EndingReservation(Reservation reservation, DateTime checkOutDate)
        {
            reservation.CheckOutDate = checkOutDate;
            return true;
        }
    }
}
