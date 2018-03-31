using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Program
    {
        private static Tank tank;
        public static void Main(string[] args)
        {
            tank = new Tank(3);
            tank.Add(8);
            tank.Add(7);
            tank.Remove();
            tank.Add(3);
            tank.Dispose();
            tank.Add(11);
            tank.Add(15);
        }
    }
}
