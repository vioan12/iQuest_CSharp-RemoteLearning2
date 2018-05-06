using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class FileDataSource : IDataSource
    {
        private string fileNameCustomers, fileNameReservations;
        public FileDataSource(string fileNameCustomers, string fileNameReservations)
        {
            this.fileNameCustomers = fileNameCustomers;
            this.fileNameReservations = fileNameReservations;
        }
        public List<Customer> CustomersList()
        {
            IRead readFile = new ReadFile(fileNameCustomers);
            IConverter<Customer> converterCustomer = new ConverterCustomer();
            return converterCustomer.Convert(readFile.Read());
        }
        public List<Reservation> ReservationsList()
        {
            IRead readFile = new ReadFile(fileNameReservations);
            IConverter<Reservation> converterReservation = new ConverterReservation();
            return converterReservation.Convert(readFile.Read());
        }
    }
}
