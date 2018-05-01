using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public abstract class WriteFile<TEntity> : IWriteFile<TEntity> where TEntity : class
    {
        protected string fileName { get; set; }
        protected TEntity entity { get; set; }
        public WriteFile(string fileName)
        {
            this.fileName = fileName;
        }
        public void Write(IEnumerable<TEntity> listWriteToFile)
        {
            try
            {
                using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(fileName))
                {
                    foreach (TEntity entity in listWriteToFile)
                    {
                        this.entity = entity;
                        outputFile.WriteLine(WriteOneLine());
                    }
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        public abstract string WriteOneLine();
    }
}
