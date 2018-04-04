using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class Compression
    {
        public void Compress(string sourceFileName)
        {
            FileInfo fi = new FileInfo(sourceFileName);
            using (FileStream inFile = fi.OpenRead())
            {
                if ((File.GetAttributes(fi.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fi.Extension != ".gz")
                {
                    using (FileStream outFile = File.Create(fi.FullName + ".gz"))
                    {
                        using (GZipStream Compress = new GZipStream(outFile, CompressionMode.Compress))
                        {
                            inFile.CopyTo(Compress);
                            Console.WriteLine("Compressed " + fi.Name + " from " + fi.Length.ToString() + "bytes to " + outFile.Length.ToString() + "bytes with " + ((double)100 * ((double)fi.Length - (double)outFile.Length) / (double)fi.Length) + "% ratio");
                        }
                    }
                }
            }
        }
    }
}
