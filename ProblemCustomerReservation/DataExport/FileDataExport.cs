using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class FileDataExport : IDataExport
    {
        private string fileNameCustomers, fileNameReservations;
        public FileDataExport(string fileNameCustomers, string fileNameReservations)
        {
            this.fileNameCustomers = fileNameCustomers;
            this.fileNameReservations = fileNameReservations;
        }
        public void Export(IEnumerable<Customer> listAllCustomers, IEnumerable<Reservation> listAllReservations)
        {
            ExportCustomers(listAllCustomers);
            ExportReservations(listAllReservations);
        }
        private void ExportCustomers(IEnumerable<Customer> listAllCustomers)
        {
            IWriteFile<Customer> customersWriteFile;
            customersWriteFile = new CustomersWriteFile(fileNameCustomers);
            customersWriteFile.Write(listAllCustomers);
        }
        public void ExportReservations(IEnumerable<Reservation> listAllReservations)
        {
            IWriteFile<Reservation> reservationsWriteFile;
            reservationsWriteFile = new ReservationsWriteFile(fileNameReservations);
            reservationsWriteFile.Write(listAllReservations);
        }

    }
}
