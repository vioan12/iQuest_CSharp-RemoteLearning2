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
            try
            {
                tank.Dispose();
            }
            catch(Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            tank.Add(11);
            tank.Add(15);
            try
            {
                tank.Dispose();
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            tank.Remove();
            tank.Remove();
            tank.Remove();
            tank.Remove();
            tank.Remove();
            try
            {
                tank.Dispose();
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            try
            {
                tank.Add(15);
                tank.Remove();
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
