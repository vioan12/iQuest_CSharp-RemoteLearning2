using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    public class Client
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string phoneNumber { get; private set; }
        public string emailAddress { get; private set; }
        public Client(string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }
    }
}
