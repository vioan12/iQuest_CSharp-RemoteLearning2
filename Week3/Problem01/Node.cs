using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Node<T>
    {
        public Node<T> Previous { get; set; }
        public T Data { get; set; }
    }
}
