using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Program
    {
        private static WriteFile writeFile;
        private static ReadFile readFile;
        public static void Main(string[] args)
        {
            writeFile = new WriteFile(Constants.FileName);
            readFile = new ReadFile(Constants.FileName);
            List<string> text = new List<string>();
            text.Add(Constants.FirstInteger.ToString());
            text.Add(Constants.SecondInteger.ToString());
            text.Add(Constants.ThirdInteger.ToString());
            text.Add(Constants.FourthInteger.ToString());
            try
            {
                writeFile.Write(text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            try
            {
                text = readFile.Read();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
