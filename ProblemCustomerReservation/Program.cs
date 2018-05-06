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
            IDataExport dataExport;
            ICustomerRepository customerRepository;
            IReservationRepository reservationRepository;
            try
            {
                HotelReservationsEntities hotelReservationsEntities = new HotelReservationsEntities();
                //dataSource = new DatabaseDataSource(hotelReservationsEntities);
                dataSource = new FileDataSource(Constants.FileNameCustomersDetails, Constants.FileNameReservationsDetails);
                dataExport = new DatabaseDataExport(hotelReservationsEntities);
                //dataExport = new FileDataExport(Constants.FileNameCustomersDetails, Constants.FileNameReservationsDetails);
                customerRepository = new CustomerRepository(dataSource);
                reservationRepository = new ReservationRepository(dataSource);
                reservationRepository.Sort();
                reservationRepository.DetectAndRemoveOverlaps();
                reservationRepository.ProposeCheckInDateAndCheckOutDate();
                dataExport.Export(customerRepository.GetAll(), reservationRepository.GetAll());
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
