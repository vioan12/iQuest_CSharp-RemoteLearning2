using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class Customer : Subject, IObserver
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string phoneNumber { get; private set; }
        public string emailAddress { get; private set; }
        public List<Domain> ownedDomains { get; private set; }
        public Customer(string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            ownedDomains = new List<Domain>();
        }
        public void Update(Domain domain)
        {
            ownedDomains.Add(domain);
        }
    }
}
