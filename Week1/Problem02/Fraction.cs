using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Fraction
    {
        public ulong Numerator { get; private set; }
        public ulong Denominator { get; private set; }
        public bool PositiveSign { get; private set; }
        public Fraction(ulong numerator, ulong denominator, bool positiveSign)
        {
            Numerator = numerator;
            Denominator = denominator;
            PositiveSign = positiveSign;
        }
    }
}
