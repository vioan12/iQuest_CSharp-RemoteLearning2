using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public interface ICustomersCollection
    {
        bool AddCustomer(Customer newCustomer);
        bool RemoveCustomer(int id);
        int CountCustomers();
        Customer GetCustomer(int index);
        List<Customer> FindByName(string customerName);
        ICollection<Reservation> GetCustomerRezervations(int id);
        Customer FindById(int id);
    }
}
