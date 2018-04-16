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
            Course courseSCD = new Course(1, "SCD");
            Course courseAPD = new Course(2, "APD");
            Student studentIoan = new Student("Ioan");
            Student studentMarius = new Student("Marius");
            Student studentCristina = new Student("Cristina");
            Teacher teacher1 = new Teacher("Mocanu", courseAPD);
            Teacher teacher2 = new Teacher("Badica", courseSCD);
            studentIoan.CreateHomework("using System; public class Program{ public static void Main(string[] args){ Console.WriteLine('This is the Ioan's homework for APD'); }}", courseAPD);
            studentIoan.CreateHomework("using System; public class Program{ public static void Main(string[] args){ Console.WriteLine('This is the Ioan's homework for SCD'); }}", courseSCD);
            studentCristina.CreateHomework("using System; public class Program{ public static void Main(string[] args){ Console.WriteLine('This is the Cristina's homework for SCD'); }}", courseSCD);
            studentIoan.SendAllHomework();
            studentMarius.CreateHomework("using System; public class Program{ public static void Main(string[] args){ Console.WriteLine('This is the Marius's homework for APD'); }}", courseAPD);
            studentMarius.CreateHomework("using System; public class Program{ public static void Main(string[] args){ Console.WriteLine('This is the Marius's homework for SCD'); }}", courseSCD);
            studentCristina.SendAllHomework();
            studentMarius.SendAllHomework();
        }
    }
}
