using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class TwoStrings
    {
        public string FirstString { get; private set; }
        public string SecondString { get; private set; }
        public TwoStrings(string firstString, string secondString)
        {
            FirstString = firstString;
            SecondString = secondString;
        }
    }
}
