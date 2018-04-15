using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Homework homeworkAPD = new Homework("using System; public class Program{ public static void Main(string[] args){ Console.WriteLine('This is the homework for APD'); }}");
            Homework homeworkSCD = new Homework("using System; public class Program{ public static void Main(string[] args){ Console.WriteLine('This is the homework for SCD'); }}");
            Course courseSCD = new Course("SCD");
            Course courseAPD = new Course("APD");
            Student studentIoan = new Student("Ioan");
            Student studentMarius = new Student("Marius");
            Student studentCristina = new Student("Cristina");
            Teacher teacher1 = new Teacher("Mocanu", courseAPD);
            Teacher teacher2 = new Teacher("Badica", courseSCD);
            studentIoan.SendHomework(homeworkAPD, courseAPD);
            studentIoan.SendHomework(homeworkSCD, courseSCD);
            studentMarius.SendHomework(homeworkSCD, courseSCD);
        }
    }
}
