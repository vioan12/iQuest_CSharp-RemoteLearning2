using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    class CustomersWriteFile : WriteFile<Customer>
    {
        public CustomersWriteFile(string fileName) : base(fileName)
        {
        }
        public override string WriteOneLine()
        {
            return entity.Id.ToString() + ";" + 
                entity.Name + ";" +
                EncryptionDecryption.EncriptPassword(entity.Password.ToString()) + ";" +
                entity.Address;
        }
    }
}
