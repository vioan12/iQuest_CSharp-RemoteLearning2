using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class Square : RegularQuadrilateral
    {
        public decimal Length { get; private set; }
        public Square(LineSegment lengthLineSegment1, LineSegment lengthLineSegment2, LineSegment lengthLineSegment3, LineSegment lengthLineSegment4) : base(lengthLineSegment1, lengthLineSegment2, lengthLineSegment3, lengthLineSegment4)
        {
            if (!(lengthLineSegment1.IsEqual(lengthLineSegment2) &&
                lengthLineSegment1.IsEqual(lengthLineSegment3) &&
                lengthLineSegment1.IsEqual(lengthLineSegment4) &&
                lengthLineSegment2.IsEqual(lengthLineSegment3) &&
                lengthLineSegment2.IsEqual(lengthLineSegment4) &&
                lengthLineSegment3.IsEqual(lengthLineSegment4)))
            {
                throw new Exception("This is not a square!!!");
            }
            else
            {
                Length = lengthLineSegment1.Size;
            }
        }
        public override decimal Area()
        {
            return Length * Length;
        }
    }
}
