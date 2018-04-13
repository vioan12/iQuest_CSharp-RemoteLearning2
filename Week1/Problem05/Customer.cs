using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string EmailAddress { get; private set; }
        public Customer(string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }
        public bool WantANewDomain(string name, string hosts, IReseller reseller)
        {
            return reseller.CreateNewDomain(name, hosts, FirstName + " " + LastName + " email:" + EmailAddress);
        }
    }
}
