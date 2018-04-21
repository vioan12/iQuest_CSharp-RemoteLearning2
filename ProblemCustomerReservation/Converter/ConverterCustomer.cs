using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public class ConverterCustomer : Converter<Customer>
    {
        public override Customer ConvertOneLine(string line)
        {
            int id;
            string name, password, address;
            splitLine = line.Split(';');
            id = int.Parse(splitLine[0]);
            name = splitLine[1];
            password = splitLine[2];
            address = splitLine[3];
            entity = new Customer(id, name, EncryptionDecryption.DecryptPassword(password), address);
            return entity;
        }
    }
}
