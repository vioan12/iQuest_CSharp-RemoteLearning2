using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class DatabaseDataExport : IDataExport, IDisposable
    {
        private HotelReservationsEntities dbContext;
        public DatabaseDataExport(HotelReservationsEntities dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Export(IEnumerable<Customer> listAllCustomers, IEnumerable<Reservation> listAllReservations)
        {
            DeleteAllReservations();
            DeleteAllCustomers();
            dbContext.SaveChanges();
            ExportCustomers(listAllCustomers);
            ExportReservations(listAllReservations);
            dbContext.SaveChanges();
        }
        private void ExportCustomers(IEnumerable<Customer> listAllCustomers)
        {
            foreach (Customer customer in listAllCustomers)
            {
                customer.Password = EncryptionDecryption.EncriptPassword(customer.Password);
                dbContext.Set<Customer>().Add(customer);
            }
        }
        private void ExportReservations(IEnumerable<Reservation> listAllReservations)
        {
            foreach (Reservation reservation in listAllReservations)
            {
                dbContext.Set<Reservation>().Add(reservation);
            }
        }
        private void DeleteAllReservations()
        {
            foreach (Reservation reservation in dbContext.Reservation)
            {
                dbContext.Set<Reservation>().Remove(reservation);
            }
        }
        private void DeleteAllCustomers()
        {
            foreach (Customer customer in dbContext.Customer)
            {
                dbContext.Set<Customer>().Remove(customer);
            }
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
