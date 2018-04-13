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
            for (int i = 0; i <= Constants.Maximum; i++)
            {
                fraction = NextTerm(i);
                division = (double)fraction.Numerator / (double)fraction.Denominator;
                if(!fraction.PositiveSign)
                {
                    division = division * (-1);
                }
                pi = pi + division;
            }
            pi = pi * 4;
        }
        private Fraction NextTerm(int index)
        {
            Fraction fraction;
            bool sign;
            if (index % 2 == 0)
            {
                sign = true;
            }
            else
            {
                sign = false;
            }
            fraction = new Fraction(1, 2 * (ulong)(index) + 1, sign);
            return fraction;
        }
    }
}
