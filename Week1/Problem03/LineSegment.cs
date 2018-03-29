using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class LineSegment
    {
        public decimal size { get; private set; }
        public LineSegment(decimal size)
        {
            if(size > 0)
            {
                this.size = size;
            }
            else
            {
                throw new Exception("This is not a line segment");
            }
        }
        public bool IsEqual(LineSegment lineSegment)
        {
            if(size == lineSegment.size)
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
