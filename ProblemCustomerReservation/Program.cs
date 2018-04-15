using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDataSource dataSource;
            ICustomerRepository customerRepository;
            IReservationRepository reservationRepository;
            try
            {
                dataSource = new FileDataSource();
                customerRepository = new CustomerRepository(dataSource);
                reservationRepository = new ReservationRepository(dataSource);
                reservationRepository.Sort();
                reservationRepository.DetectAndRemoveOverlaps();
                DateTime date = default(DateTime);
                date.AddMonths(04);
                date.AddYears(2018);
                date.AddDays(06);
                //date = reservationRepository.ProposeCheckInDate(date);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
