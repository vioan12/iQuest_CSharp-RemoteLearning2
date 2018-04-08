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
        private static RegularQuadrilateral[] shape;
        public static void Main(string[] args)
        {
            shape = new RegularQuadrilateral[2];
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
                shape[0] = new Square(lineSegment1, lineSegment1, lineSegment1, lineSegment1);
                System.Console.WriteLine("Perimeter:" + shape[0].Perimeter());
                System.Console.WriteLine("Area:" + shape[0].Area());
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            try
            {
                shape[1] = new Rectangle(lineSegment3, lineSegment1, lineSegment1, lineSegment3);
                System.Console.WriteLine("Perimeter:" + shape[1].Perimeter());
                System.Console.WriteLine("Area:" + shape[1].Area());
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
