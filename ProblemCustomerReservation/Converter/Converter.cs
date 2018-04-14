using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCustomerReservation
{
    public abstract class Converter<TEntity> : IConverter<TEntity> where TEntity : class
    {
        protected string[] splitLine { get; set; }
        protected TEntity entity { get; set; }
        public List<TEntity> Convert(List<string> lines)
        {
            List<TEntity> entitysList = new List<TEntity>();
            foreach (string line in lines)
            {
                entitysList.Add(ConvertOneLine(line));
            }
            return entitysList;
        }
        public abstract TEntity ConvertOneLine(string line);
    }
}