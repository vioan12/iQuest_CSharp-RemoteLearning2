using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public static class Constants
    {
        public const string FileNameCustomersDetails = "DataSource/Customers.csv";
        public const string FileNameReservationsDetails = "DataSource/Reservations.csv";
        public const string Key = "Ioan";
        public const int DefaultHotelId = 0;
        public static readonly Hotel Hotel;
        static Constants()
        {
            Hotel = new Hotel(421, "Cabana Plapumioara", "Brasov");
        }
    }
}
