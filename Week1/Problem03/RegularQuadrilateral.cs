using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public abstract class RegularQuadrilateral
    {
        public LineSegment[] LineSegmentsList { get; private set; }
        public RegularQuadrilateral(LineSegment lengthLineSegment1, LineSegment lengthLineSegment2, LineSegment lengthLineSegment3, LineSegment lengthLineSegment4)
        {
            LineSegmentsList = new LineSegment[4];
            LineSegmentsList[0] = lengthLineSegment1;
            LineSegmentsList[1] = lengthLineSegment2;
            LineSegmentsList[2] = lengthLineSegment3;
            LineSegmentsList[3] = lengthLineSegment4;
        }
        public decimal Perimeter()
        {
            return LineSegmentsList[0].Size + LineSegmentsList[1].Size + LineSegmentsList[2].Size + LineSegmentsList[3].Size;
        }
        public abstract decimal Area();
    }
}
