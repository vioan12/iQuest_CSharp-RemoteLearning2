using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        void Sort();
        IEnumerable<Reservation> DetectAndRemoveOverlaps();
        IEnumerable<CheckInOutDates> ProposeCheckInDateAndCheckOutDate();
    }
}
