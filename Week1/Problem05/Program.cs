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
        private static Reseller reseller;
        private static Registrar registrar;
        public static void Main(string[] args)
        {
            customer = new Customer("Dan", "Florea", "015714", "dandan2@gmail.com");
            reseller = new Reseller();
            registrar = new Registrar();
            customer.Attach(reseller);
            reseller.Attach(registrar);
            registrar.Attach(customer);
            Domain domain = new Domain("facebook", ".ro", customer.emailAddress);
            try
            {
                customer.Notify(domain);
                customer.Notify(domain);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            try
            {
                domain = new Domain("facebook", ".en", customer.emailAddress);
                customer.Notify(domain);
                customer.Notify(domain);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            try
            {
                domain = new Domain("acer", ".en", customer.emailAddress);
                customer.Notify(domain);
                customer.Notify(domain);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
