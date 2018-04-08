using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class LineSegment
    {
        public decimal Size { get; private set; }
        public LineSegment(decimal size)
        {
            if(size > 0)
            {
                Size = size;
            }
            else
            {
                throw new Exception("This is not a line segment");
            }
        }
        public bool IsEqual(LineSegment lineSegment)
        {
            if(Size == lineSegment.Size)
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
