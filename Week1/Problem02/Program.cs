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
            System.Console.WriteLine("[ComputePI]: " + computePI.pi.ToString());
            System.Console.WriteLine("[Math.PI]:   " + Math.PI.ToString());
            System.Console.WriteLine("Difference between two values is " + Math.Abs(computePI.pi - Math.PI));
        }
    }
}
