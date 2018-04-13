using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public class Program
    {
        private static CustomersCollection customersCollection;
        private static IRepository<Customer> customerRepository;
        private static IRepository<UsernameReservation> reservationRepository;
        public static void Main(string[] args)
        {
            customersCollection = new CustomersCollection();
            customerRepository = new CustomerRepository(customersCollection);
            reservationRepository = new ReservationRepository(customersCollection);
            try
            {
                List<string> customersFileLines, reservationsFileLines;
                List<Customer> customersList;
                List<UsernameReservation> usernameReservationsList;
                Converter converter = new Converter();
                IRead readFile;
                readFile = new ReadFile(Constants.FileNameCustomersDetails);
                customersFileLines = readFile.Read();
                readFile = new ReadFile(Constants.FileNameReservationsDetails);
                reservationsFileLines = readFile.Read();
                customersList = converter.ConvertCustomersFile(customersFileLines);
                usernameReservationsList = converter.ConvertReservationsFile(reservationsFileLines);
                foreach (Customer customer in customersList)
                {
                    customerRepository.Add(customer);
                }
                foreach (UsernameReservation usernameAndReservation in usernameReservationsList)
                {
                    reservationRepository.Add(usernameAndReservation);
                }
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
