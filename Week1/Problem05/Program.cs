using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class Program
    {
        private static Customer customer;
        private static IReseller reseller;
        public static void Main(string[] args)
        {
            ReadFile readFile = new ReadFile(Constants.CustomerFileName);
            ConverterCustomer converterCustomer = new ConverterCustomer();
            ConverterDomain converterDomain = new ConverterDomain();
            customer = converterCustomer.Convert(readFile.Read()).ElementAt(0);
            reseller = new Reseller();
            readFile = new ReadFile(Constants.DomainFileName);
            List<TwoStrings> domains;
            domains = converterDomain.Convert(readFile.Read());
            customer.WantANewDomain(domains.ElementAt(0).FirstString, domains.ElementAt(0).SecondString, reseller);
            customer.WantANewDomain(domains.ElementAt(0).FirstString, domains.ElementAt(0).SecondString, reseller);
            customer.WantANewDomain(domains.ElementAt(1).FirstString, domains.ElementAt(1).SecondString, reseller);
            customer.WantANewDomain(domains.ElementAt(1).FirstString, domains.ElementAt(1).SecondString, reseller);
            customer.WantANewDomain(domains.ElementAt(1).FirstString, domains.ElementAt(1).SecondString, reseller);
            customer.WantANewDomain(domains.ElementAt(2).FirstString, domains.ElementAt(2).SecondString, reseller);
            customer.WantANewDomain(domains.ElementAt(2).FirstString, domains.ElementAt(2).SecondString, reseller);
        }
    }
}
