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
            entity.Id = int.Parse(splitLine[0]);
            entity.Name = splitLine[1];
            entity.Password = EncryptionDecryption.DecryptPassword(splitLine[2]);
            entity.Address = splitLine[3];
            return entity;
        }
    }
}
