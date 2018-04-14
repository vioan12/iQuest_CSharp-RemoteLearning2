using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class Reservation : IEntity
    {
        public int Id { get; private set; }
        public int CustomerId { get; private set; }
        public DateTime CheckInDate { get; internal set; }
        public DateTime CheckOutDate { get; internal set; }
        public Hotel Hotel { get; private set; }
        public Reservation(int reservationId, int customerId, Hotel hotel)
        {
            Id = reservationId;
            CustomerId = customerId;
            Hotel = hotel;
            CheckInDate = default(DateTime);
            CheckOutDate = default(DateTime);
        }
    }
}
