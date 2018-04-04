using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public class HotelManager
    {
        public Hotel Hotel { get; private set; }
        public HotelManager(Hotel hotel)
        {
            Hotel = hotel;
        }
        public Reservation CreateReservation(string checkInDate)
        {
            Reservation reservation = new Reservation(Hotel);
            reservation.CheckInDate = checkInDate;
            return reservation;
        }
        public bool EndingReservation(Reservation reservation, string checkOutDate)
        {
            reservation.CheckOutDate = checkOutDate;
            return true;
        }
    }
}
