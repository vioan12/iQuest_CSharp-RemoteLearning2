using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class Program
    {
        private static Compression compression;
        public static void Main(string[] args)
        {
            List<FileLength> inputOutputFiles;
            compression = new Compression();
            inputOutputFiles = compression.Compress(Constants.SourceFileName);
            Console.WriteLine("Compressed " + inputOutputFiles.ElementAt(0).Name + " from " + inputOutputFiles.ElementAt(0).Length.ToString() + "bytes to " + inputOutputFiles.ElementAt(1).Length.ToString() + "bytes with " + ((double)100 * ((double)inputOutputFiles.ElementAt(0).Length - (double)inputOutputFiles.ElementAt(1).Length) / (double)inputOutputFiles.ElementAt(0).Length) + "% ratio");
        }
    }
}
