using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(IDataSource dataSource) : base(dataSource.ReservationsList())
        {
        }
        public void Sort()
        {
            Data = Data.OrderBy(entity => entity.CheckInDate);
        }
        public IEnumerable<Reservation> DetectAndRemoveOverlaps()
        {
            Sort();
            IEnumerable<Reservation> overlapsReservations = new List<Reservation>();
            bool condition;
            for (int i = Data.Count() - 1; i >= 1 ; i--)
            {
                condition = false;
                for (int j = i - 1; (j >= 0) && (condition == false); j--)
                {
                    if (Data.ElementAt(i).CheckInDate < Data.ElementAt(j).CheckOutDate)
                    {
                        overlapsReservations = overlapsReservations.Concat(new[] { Data.ElementAt(i) });
                        condition = true;
                    }
                }
            }
            foreach(Reservation reservation in overlapsReservations)
            {
                Data = Data.Where(entity => entity.Id != reservation.Id);
            }
            return overlapsReservations;
        }
        public IEnumerable<CheckInOutDates> ProposeCheckInDateAndCheckOutDate()
        {
            List<CheckInOutDates> checkInOutDatesList = new List<CheckInOutDates>();
            CheckInOutDates checkInOutDates;
            DetectAndRemoveOverlaps();
            for (int i = 0; i < Data.Count() - 1; i++)
            {
                if(Data.ElementAt(i).CheckOutDate != Data.ElementAt(i+1).CheckInDate)
                {
                    checkInOutDates = new CheckInOutDates(Data.ElementAt(i).CheckOutDate.Value, Data.ElementAt(i + 1).CheckInDate);
                    checkInOutDatesList.Add(checkInOutDates);
                }
            }
            checkInOutDates = new CheckInOutDates(Data.ElementAt(Data.Count() - 1).CheckOutDate.Value, DateTime.MaxValue);
            checkInOutDatesList.Add(checkInOutDates);
            return checkInOutDatesList;
        }
    }
}
