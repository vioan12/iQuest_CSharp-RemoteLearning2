using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class ConverterCustomer : Converter<Customer>
    {
        public ConverterCustomer()
        {
        }
        public override Customer ConvertOneLine(string line)
        {
            string firstName, lastName, phoneNumber, emailAddress;
            firstName = lastName = phoneNumber = emailAddress = "";
            splitLine = line.Split(';');
            firstName = splitLine[0];
            lastName = splitLine[1];
            phoneNumber = splitLine[2];
            emailAddress = splitLine[3];
            entity = new Customer(firstName, lastName, phoneNumber, emailAddress);
            return entity;
        }
    }
}
