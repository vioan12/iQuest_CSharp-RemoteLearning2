using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    public interface IConverter<TEntity> where TEntity : class
    {
        List<TEntity> Convert(List<string> lines);
        TEntity ConvertOneLine(string line);
    }
}
