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
            compression = new Compression();
            compression.Compress(Constants.SourceFileName);
        }
    }
}
