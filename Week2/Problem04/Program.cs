using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public class Program
    {
        private static ReadFiles readFile;
        private static CustomersCollection customersCollection;
        public static void Main(string[] args)
        {
            customersCollection = new CustomersCollection();
            readFile = new ReadFiles(Constants.FileNameCustomersDetails, Constants.FileNameReservationsDetails, customersCollection);
            readFile.Read();
        }
    }
}
