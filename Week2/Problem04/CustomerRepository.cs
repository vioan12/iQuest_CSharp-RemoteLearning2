using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public class CustomerRepository : IRepository<Customer>
    {
        private ICustomersCollection context;
        public CustomerRepository(ICustomersCollection context)
        {
            this.context = context;
        }
        public void Add(Customer entity)
        {
            context.AddCustomer(entity);
        }
        public List<Customer> GetAll()
        {
            List<Customer> allCustomer = new List<Customer>();
            for(int index = 0; index < context.CountCustomers(); index++)
            {
                allCustomer.Add(context.GetCustomer(index));
            }
            return allCustomer;
        }
        public Customer GetById(string username)
        {
            return context.FindByUsername(username);
        }
        public void Remove(string username)
        {
            context.RemoveCustomer(context.FindByUsername(username));
        }
    }
}
