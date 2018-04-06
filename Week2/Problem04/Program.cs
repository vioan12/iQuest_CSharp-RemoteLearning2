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
        public static void Main(string[] args)
        {
            customersCollection = new CustomersCollection();
            try
            {
                List<string> customersFileLines, reservationsFileLines;
                List<Customer> customersList;
                List<UsernameReservation> usernameReservationsList;
                Converter converter = new Converter();
                ReadFile readFile;
                readFile = new ReadFile(Constants.FileNameCustomersDetails);
                customersFileLines = readFile.Read();
                readFile = new ReadFile(Constants.FileNameReservationsDetails);
                reservationsFileLines = readFile.Read();
                customersList = converter.ConvertCustomersFile(customersFileLines);
                usernameReservationsList = converter.ConvertReservationsFile(reservationsFileLines);
                foreach (Customer customer in customersList)
                {
                    customersCollection.AddCustomer(customer);
                }
                foreach (UsernameReservation usernameAndReservation in usernameReservationsList)
                {
                    customersCollection.FindByUsername(usernameAndReservation.Username).AddReservation(usernameAndReservation.Reservation);
                }
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
