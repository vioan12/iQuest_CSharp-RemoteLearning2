using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class FileLength
    {
        public string Name { get; private set; }
        public long Length { get; private set; }
        public FileLength(string name, long length)
        {
            Name = name;
            Length = length;
        }
    }
}
