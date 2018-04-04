using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class WriteFile
    {
        private string fileName;
        public WriteFile(string fileName)
        {
            this.fileName = fileName;
        }
        public bool Write(List<string> text)
        {
            try
            {
                using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(fileName))
                {
                    foreach (string line in text)
                    {
                        outputFile.WriteLine(line);
                    }
                    return true;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
