using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class Rectangle : RegularQuadrilateral 
    {
        public decimal Length { get; private set; }
        public decimal Width { get; private set; }
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
                    if(lengthLineSegment1.Size > lengthLineSegment3.Size)
                    {
                        Length = lengthLineSegment1.Size;
                        Width = lengthLineSegment3.Size;
                    }
                    else
                    {
                        Length = lengthLineSegment3.Size;
                        Width = lengthLineSegment1.Size;
                    }
                }
                if(lengthLineSegment1.IsEqual(lengthLineSegment3) && lengthLineSegment2.IsEqual(lengthLineSegment4))
                {
                    if (lengthLineSegment1.Size > lengthLineSegment2.Size)
                    {
                        Length = lengthLineSegment1.Size;
                        Width = lengthLineSegment2.Size;
                    }
                    else
                    {
                        Length = lengthLineSegment2.Size;
                        Width = lengthLineSegment1.Size;
                    }
                }
                if(lengthLineSegment1.IsEqual(lengthLineSegment4) && lengthLineSegment2.IsEqual(lengthLineSegment3))
                {
                    if (lengthLineSegment1.Size > lengthLineSegment2.Size)
                    {
                        Length = lengthLineSegment1.Size;
                        Width = lengthLineSegment2.Size;
                    }
                    else
                    {
                        Length = lengthLineSegment2.Size;
                        Width = lengthLineSegment1.Size;
                    }
                }
            }
        }
        public override decimal Area()
        {
            return Length * Width;
        }
    }
}
