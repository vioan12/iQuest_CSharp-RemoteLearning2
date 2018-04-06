using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public interface IStack<T>
    {
        bool Push(T newItem);
        bool Pop();
        T Peek();
    }
}
