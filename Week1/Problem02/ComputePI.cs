using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class ComputePI
    {
        public double pi { private set; get; }
        public ComputePI()
        {
            pi = 0;
            Calculate();
        }
        private void Calculate()
        {
            double division;
            Fraction fraction;
            for (int i = 0; i <= Constants.max; i++)
            {
                fraction = NextTerm(i);
                division = (double)fraction.numerator / (double)fraction.denominator;
                if(!fraction.positiveSign)
                {
                    division = division * (-1);
                }
                pi = pi + division;
            }
            pi = pi * 4;
        }
        private Fraction NextTerm(int index)
        {
            Fraction fraction = new Fraction();
            fraction.numerator = 1;
            fraction.denominator = 2 * (ulong)(index) + 1;
            if (index % 2 == 0)
            {
                fraction.positiveSign = true;
            }
            else
            {
                fraction.positiveSign = false;
            }
            return fraction;
        }
    }
}
