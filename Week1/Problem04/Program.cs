using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public class Program
    {
        private static PrimeNumberVerifier primeNumberVerifier;
        public static int Main(string[] args)
        {
            int maximumNumber;
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a numeric argument.");
                return 1;
            }
            bool test = int.TryParse(args[0], out maximumNumber);
            if (test == false)
            {
                System.Console.WriteLine("Please enter a correct numeric argument.");
                return 1;
            }
            primeNumberVerifier = new PrimeNumberVerifier();
            System.Console.Write("1");
            for (int i = 2; i <= maximumNumber; i++)
            {
                if (primeNumberVerifier.IsPrime(i))
                {
                    System.Console.Write(", " + i + "-PRIME");
                }
                else
                {
                    System.Console.Write(", " + i);
                }
            }
            return 0;
        }
    }
}
