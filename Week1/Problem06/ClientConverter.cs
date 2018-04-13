using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    public class ClientConverter : Converter<Client>
    {
        public override Client ConvertOneLine(string line)
        {
            string firstName, lastName, phoneNumber, emailAddress;
            firstName = lastName = phoneNumber = emailAddress = "";
            splitLine = line.Split(';');
            firstName = splitLine[0];
            lastName = splitLine[1];
            phoneNumber = splitLine[2];
            emailAddress = splitLine[3];
            entity = new Client(firstName, lastName, phoneNumber, emailAddress);
            return entity;
        }
    }
}
