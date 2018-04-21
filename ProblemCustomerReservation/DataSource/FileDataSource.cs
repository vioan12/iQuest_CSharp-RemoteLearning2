using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class FileDataSource : IDataSource
    {
        public List<Customer> CustomersList()
        {
            IRead readFile = new ReadFile(Constants.FileNameCustomersDetails);
            IConverter<Customer> converterCustomer = new ConverterCustomer();
            return converterCustomer.Convert(readFile.Read());
        }
        public List<Reservation> ReservationsList()
        {
            IRead readFile = new ReadFile(Constants.FileNameReservationsDetails);
            IConverter<Reservation> converterReservation = new ConverterReservation();
            return converterReservation.Convert(readFile.Read());
        }
    }
}
