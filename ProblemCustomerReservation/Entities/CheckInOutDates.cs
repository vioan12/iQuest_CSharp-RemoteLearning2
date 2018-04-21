using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class CheckInOutDates
    {
        public DateTime CheckInDate { get; private set; }
        public DateTime CheckOutDate { get; private set; }
        public CheckInOutDates(DateTime checkInDate, DateTime checkOutDate)
        {
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
    }
}
