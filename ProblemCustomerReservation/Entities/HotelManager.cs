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
        public Reservation CreateReservation(int reservationId, int customerId, DateTime checkInDate)
        {
            Reservation reservation = new Reservation(reservationId, customerId, Hotel);
            reservation.CheckInDate = checkInDate;
            return reservation;
        }
        public bool EndingReservation(Reservation reservation, DateTime checkOutDate)
        {
            reservation.CheckOutDate = checkOutDate;
            return true;
        }
    }
}
