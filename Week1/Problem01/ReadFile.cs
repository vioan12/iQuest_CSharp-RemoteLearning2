using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class ReadFile
    {
        private string fileName;
        public ReadFile(string fileName)
        {
            this.fileName = fileName;
        }
        public List<string> Read()
        {
            string line;
            List<string> allLines = new List<string>();
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(fileName))
                    while ((line = file.ReadLine()) != null)
                    {
                        allLines.Add(line);
                    }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return allLines;
        }
    }
}
