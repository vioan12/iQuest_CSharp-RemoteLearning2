using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
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
            List<string> text = new List<string>();
            try
            {
                using (System.IO.StreamReader inputFile = new System.IO.StreamReader(fileName))
                {
                    string line;
                    inputFile.BaseStream.Seek(Constants.firstInteger.ToString().Length + 2, System.IO.SeekOrigin.Begin);
                    inputFile.BaseStream.Seek(Constants.secondInteger.ToString().Length + 2, System.IO.SeekOrigin.Current);
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        text.Add(line);
                    }
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return text;
        }
    }
}
