using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class Rectangle : RegularQuadrilateral 
    {
        public decimal length { get; private set; }
        public decimal width { get; private set; }
        public Rectangle(LineSegment lengthLineSegment1, LineSegment lengthLineSegment2, LineSegment lengthLineSegment3, LineSegment lengthLineSegment4) : base(lengthLineSegment1, lengthLineSegment2, lengthLineSegment3, lengthLineSegment4)
        {
            if (!((lengthLineSegment1.IsEqual(lengthLineSegment2) && lengthLineSegment3.IsEqual(lengthLineSegment4)) ||
                    (lengthLineSegment1.IsEqual(lengthLineSegment3) && lengthLineSegment2.IsEqual(lengthLineSegment4)) ||
                    (lengthLineSegment1.IsEqual(lengthLineSegment4) && lengthLineSegment2.IsEqual(lengthLineSegment3))))
            {
                throw new Exception("This is not a rectangle!!!");
            }
            else
            {
                if(lengthLineSegment1.IsEqual(lengthLineSegment2) && lengthLineSegment3.IsEqual(lengthLineSegment4))
                {
                    if(lengthLineSegment1.size > lengthLineSegment3.size)
                    {
                        length = lengthLineSegment1.size;
                        width = lengthLineSegment3.size;
                    }
                    else
                    {
                        length = lengthLineSegment3.size;
                        width = lengthLineSegment1.size;
                    }
                }
                if(lengthLineSegment1.IsEqual(lengthLineSegment3) && lengthLineSegment2.IsEqual(lengthLineSegment4))
                {
                    if (lengthLineSegment1.size > lengthLineSegment2.size)
                    {
                        length = lengthLineSegment1.size;
                        width = lengthLineSegment2.size;
                    }
                    else
                    {
                        length = lengthLineSegment2.size;
                        width = lengthLineSegment1.size;
                    }
                }
                if(lengthLineSegment1.IsEqual(lengthLineSegment4) && lengthLineSegment2.IsEqual(lengthLineSegment3))
                {
                    if (lengthLineSegment1.size > lengthLineSegment2.size)
                    {
                        length = lengthLineSegment1.size;
                        width = lengthLineSegment2.size;
                    }
                    else
                    {
                        length = lengthLineSegment2.size;
                        width = lengthLineSegment1.size;
                    }
                }
            }
        }
        public override decimal Area()
        {
            return length * width;
        }
    }
}
