using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public interface ICustomersCollection
    {
        bool AddCustomer(Customer newCustomer);
        bool RemoveCustomer(Customer removableCustomer);
        int CountCustomers();
        Customer GetCustomer(int index);
        List<Customer> FindByName(string customerName);
        List<Reservation> GetCustomerRezervations(string customerUsername);
        Customer FindByUsername(string customerUsername);
    }
}
