using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Program
    {
        private static ComputePI computePI;
        public static void Main(string[] args)
        {
            computePI = new ComputePI();
            System.Console.WriteLine("[ComputePi]: {0}", computePI.pi.ToString());
            System.Console.WriteLine("[Math.PI]:   {0}", Math.PI.ToString());
            System.Console.WriteLine("The difference is {0} decimal places", ComparePI.Compare(computePI.pi).ToString());
        }
    }
}
