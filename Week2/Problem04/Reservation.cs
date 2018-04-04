using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public class Reservation
    {
        public string CheckInDate { get; internal set; }
        public string CheckOutDate { get; internal set; }
        public Hotel Hotel { get; private set; }
        public Reservation(Hotel hotel)
        {
            Hotel = hotel;
            CheckInDate = "";
            CheckOutDate = "";
        }
    }
}
