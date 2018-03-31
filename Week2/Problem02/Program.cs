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
            writeFile = new WriteFile(Constants.fileName);
            readFile = new ReadFile(Constants.fileName);
            List<string> text = new List<string>();
            text.Add(Constants.firstInteger.ToString());
            text.Add(Constants.secondInteger.ToString());
            text.Add(Constants.thirdInteger.ToString());
            text.Add(Constants.fourthInteger.ToString());
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
