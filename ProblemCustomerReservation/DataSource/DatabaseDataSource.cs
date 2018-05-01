using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class DatabaseDataSource : IDataSource, IDisposable
    {
        private readonly HotelReservationsEntities dbContext;
        public DatabaseDataSource(HotelReservationsEntities dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Customer> CustomersList()
        {
            List<Customer> allCustomers = new List<Customer>();
            foreach (Customer customer in dbContext.Customer)
            {
                customer.Password = EncryptionDecryption.DecryptPassword(customer.Password);
                allCustomers.Add(customer);
            }
            return allCustomers;
        }
        public List<Reservation> ReservationsList()
        {
            List<Reservation> allReservations = new List<Reservation>();
            foreach (Reservation reservation in dbContext.Reservation)
            {
                reservation.Hotel = Constants.Hotel;
                allReservations.Add(reservation);
            }
            return allReservations;
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
