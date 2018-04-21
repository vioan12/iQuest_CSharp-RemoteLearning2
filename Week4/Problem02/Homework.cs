using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Homework
    {
        public string Content { get; private set; }
        public int Grade { get; internal set; }
        public Homework(string content)
        {
            Content = content;
        }
    }
}
