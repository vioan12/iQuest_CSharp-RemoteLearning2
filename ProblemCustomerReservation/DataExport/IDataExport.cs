using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public interface IDataExport
    {
        void Export(IEnumerable<Customer> listAllCustomers, IEnumerable<Reservation> listAllReservations);
    }
}
