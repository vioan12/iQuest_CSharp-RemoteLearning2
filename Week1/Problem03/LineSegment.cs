using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class LineSegment
    {
        public Point[] points { get; private set; }
        public LineSegment(Point point1, Point point2)
        {
            points = new Point[2];
            if(!point1.IsEqual(point2))
            {
                points[0] = point1;
                points[1] = point2;
            }
            else
            {
                throw new Exception("This is not a line segment");
            }
        }
        public bool IsEqual(LineSegment lineSegment)
        {
            if ((points[0].IsEqual(lineSegment.points[0]) && points[1].IsEqual(lineSegment.points[1]))
                || (points[0].IsEqual(lineSegment.points[1]) && points[1].IsEqual(lineSegment.points[0])))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow((points[0].abscissa - points[1].abscissa) , 2) + Math.Pow((points[0].ordinate - points[1].ordinate) , 2));
        }
        public Point CommonPoint(LineSegment lineSegment)
        {
            if (points[0].IsEqual(lineSegment.points[0]) || points[1].IsEqual(lineSegment.points[1])
                || points[0].IsEqual(lineSegment.points[1]) || points[1].IsEqual(lineSegment.points[0]))
            {
                Point point = new Point();
                if (points[0].IsEqual(lineSegment.points[0]))
                {
                    point.abscissa = points[0].abscissa;
                    point.ordinate = points[0].ordinate;
                }
                if(points[1].IsEqual(lineSegment.points[1]))
                {
                    point.abscissa = points[1].abscissa;
                    point.ordinate = points[1].ordinate;
                }
                if(points[0].IsEqual(lineSegment.points[1]))
                {
                    point.abscissa = points[0].abscissa;
                    point.ordinate = points[0].ordinate;
                }
                if(points[1].IsEqual(lineSegment.points[0]))
                {
                    point.abscissa = points[1].abscissa;
                    point.ordinate = points[1].ordinate;
                }
                return point;
            }
            else
            {
                throw new Exception("They do not have a common point");
            }
        }
    }
}
