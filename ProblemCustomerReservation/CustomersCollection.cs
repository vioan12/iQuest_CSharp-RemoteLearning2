using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class CustomersCollection : ICustomersCollection
    {
        private List<Customer> customersList { get; set; }
        public CustomersCollection()
        {
            customersList = new List<Customer>();
        }
        public bool AddCustomer(Customer newCustomer)
        {
            foreach(Customer customer in customersList)
            {
                if(customer.IsEqualId(newCustomer.Id))
                {
                    return false;
                }
            }
            customersList.Add(newCustomer);
            return true;
        }
        public bool RemoveCustomer(int id)
        {
            foreach (Customer customer in customersList)
            {
                if (customer.IsEqualId(id))
                {
                    customersList.Remove(customer);
                    return true;
                }
            }
            return false;
        }
        public int CountCustomers()
        {
            return customersList.Count;
        }
        public Customer GetCustomer(int index)
        {
            if((index < customersList.Count) && (index >= 0))
            {
                return customersList.ElementAt(index);
            }
            else
            {
                return null;
            }
        }
        public List<Customer> FindByName(string customerName)
        {
            List<Customer> customersListFindByName = new List<Customer>();
            foreach (Customer customer in customersList)
            {
                if (customer.IsEqualName(customerName))
                {
                    customersListFindByName.Add(customer);
                }
            }
            return customersListFindByName;
        }
        public List<Reservation> GetCustomerRezervations(int id)
        {
            foreach (Customer customer in customersList)
            {
                if (customer.IsEqualId(id))
                {
                    return customer.ReservationsList;
                }
            }
            return null;
        }
        public Customer FindById(int id)
        {
            foreach (Customer customer in customersList)
            {
                if (customer.IsEqualId(id))
                {
                    return customer;
                }
            }
            return null;
        }
    }
}
