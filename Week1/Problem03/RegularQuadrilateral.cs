using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public abstract class RegularQuadrilateral
    {
        public LineSegment[] lineSegmentsList { get; private set; }
        public RegularQuadrilateral(LineSegment lengthLineSegment1, LineSegment lengthLineSegment2, LineSegment lengthLineSegment3, LineSegment lengthLineSegment4)
        {
            lineSegmentsList = new LineSegment[4];
            lineSegmentsList[0] = lengthLineSegment1;
            lineSegmentsList[1] = lengthLineSegment2;
            lineSegmentsList[2] = lengthLineSegment3;
            lineSegmentsList[3] = lengthLineSegment4;
        }
        public decimal Perimeter()
        {
            return lineSegmentsList[0].size + lineSegmentsList[1].size + lineSegmentsList[2].size + lineSegmentsList[3].size;
        }
        public abstract decimal Area();
    }
}
