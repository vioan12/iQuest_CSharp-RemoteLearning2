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
        public List<FileLength> Compress(string sourceFileName)
        {
            FileInfo fi = new FileInfo(sourceFileName);
            List<FileLength> inputOutputFilesLength = new List<FileLength>();
            using (FileStream inFile = fi.OpenRead())
            {
                if ((File.GetAttributes(fi.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fi.Extension != ".gz")
                {
                    using (FileStream outFile = File.Create(fi.FullName + ".gz"))
                    {
                        using (GZipStream Compress = new GZipStream(outFile, CompressionMode.Compress))
                        {
                            inFile.CopyTo(Compress);
                            FileLength inputFile = new FileLength(fi.Name, fi.Length);
                            FileLength outputFile = new FileLength(outFile.Name, outFile.Length);
                            inputOutputFilesLength.Add(inputFile);
                            inputOutputFilesLength.Add(outputFile);
                        }
                    }
                }
            }
            return inputOutputFilesLength;
        }
    }
}
