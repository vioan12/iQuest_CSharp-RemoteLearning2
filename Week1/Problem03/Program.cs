using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class Program
    {
        private static LineSegment lineSegment1, lineSegment2, lineSegment3;
        private static RegularQuadrilateral shape;
        public static void Main(string[] args)
        {
            try
            {
                lineSegment1 = new LineSegment(5);
                lineSegment3 = new LineSegment(8);
                lineSegment2 = new LineSegment(-2);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            try
            {
                shape = new Square(lineSegment1, lineSegment1, lineSegment1, lineSegment1);
                System.Console.WriteLine("Perimeter:" + shape.Perimeter());
                System.Console.WriteLine("Area:" + shape.Area());
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            try
            {
                shape = new Rectangle(lineSegment3, lineSegment1, lineSegment1, lineSegment3);
                System.Console.WriteLine("Perimeter:" + shape.Perimeter());
                System.Console.WriteLine("Area:" + shape.Area());
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
