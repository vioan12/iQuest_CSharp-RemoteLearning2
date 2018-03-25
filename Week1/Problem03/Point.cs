using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class Point
    {
        public double abscissa { get; set; }
        public double ordinate { get; set; }
        public bool IsEqual(Point point)
        {
            if(abscissa == point.abscissa && ordinate == point.ordinate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
