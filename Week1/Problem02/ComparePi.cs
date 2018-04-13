using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public static class ComparePI
    {
        public static int Compare(double computePI)
        {
            int counter = 0;
            double difference = Math.Abs(Math.PI - computePI);
            while(Convert.ToInt32(difference) == 0)
            {
                counter++;
                difference = difference * 10;
            }
            return counter;
        }
    }
}
