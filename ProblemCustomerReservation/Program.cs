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
            IRepository<Customer> customerRepository;
            IRepository<Reservation> reservationRepository;
            try
            {
                dataSource = new FileDataSource();
                customerRepository = new CustomerRepository(dataSource);
                reservationRepository = new ReservationRepository(dataSource);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
