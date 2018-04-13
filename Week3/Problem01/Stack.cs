using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Stack<T> : IStack<T>
    {
        private Node<T> topItem { get; set; }
        public Stack()
        {
            topItem = null;
        }
        public bool Push(T newItem)
        {
            if (topItem != null)
            {
                Node<T> currentItem;
                currentItem = topItem;
                topItem = new Node<T>();
                topItem.Previous = currentItem;
                topItem.Data = newItem;
            }
            else
            {
                topItem = new Node<T>();
                topItem.Data = newItem;
                topItem.Previous = null;
            }
            return true;
        }
        public bool Pop()
        {
            if (topItem != null)
            {
                topItem = topItem.Previous;
                return true;
            }
            return false;
        }
        public T Peek()
        {
            if(topItem != null)
            {
                return topItem.Data;
            }
            throw new Exception("There is no elements in the stack");
        }
    }
}
