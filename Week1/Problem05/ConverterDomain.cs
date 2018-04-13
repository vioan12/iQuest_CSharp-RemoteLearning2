using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    public class ConverterDomain : Converter<TwoStrings>
    {
        public ConverterDomain()
        {
        }
        public override TwoStrings ConvertOneLine(string line)
        {
            string name, hosts;
            name = hosts = "";
            splitLine = line.Split(';');
            name = splitLine[0];
            hosts = splitLine[1];
            entity = new TwoStrings(name, hosts);
            return entity;
        }
    }

}
