using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public class PrimeNumberVerifier
    {
        public PrimeNumberVerifier()
        {
        }
        public bool IsPrime(int number)
        {
            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
