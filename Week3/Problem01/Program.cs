using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Program
    {
        private static IStack<int> stack;
        public static void Main(string[] args)
        {
            try
            {
                stack = new Stack<int>();
                stack.Pop();
                stack.Push(12);
                stack.Peek();
                stack.Push(-5);
                stack.Peek();
                stack.Push(100);
                stack.Pop();
                stack.Peek();
                stack.Push(50);
                stack.Pop();
                stack.Peek();
                stack.Peek();
                stack.Pop();
                stack.Pop();
                stack.Pop();
                stack.Push(77);
                stack.Peek();
                stack.Push(777);
                stack.Peek();
                stack.Push(7777);
                stack.Peek();
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
