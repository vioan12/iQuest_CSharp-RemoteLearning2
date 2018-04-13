using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Tank : IDisposable
    {
        private Object[] stack;
        private int numberOfItems;
        private bool disposed = false;
        public Tank(int maximumSize)
        {
            stack = new Object[maximumSize];
            numberOfItems = 0;
        }
        public bool Add(Object item)
        {
            if (!disposed)
            {
                if (numberOfItems < stack.Length)
                {
                    stack[numberOfItems++] = item;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("The stack was disposed");
            }
        }
        public bool Remove()
        {
            if (!disposed)
            {
                if (numberOfItems > 0)
                {
                    stack[--numberOfItems] = null;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("The stack was disposed");
            }
        }
        public void Dispose()
        {
            if (numberOfItems == 0)
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            else
            {
                throw new Exception("The stack still contains elements");
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
            }

            // Free any unmanaged objects here.
            for (int i = 0; i < numberOfItems; i++)
            {
                stack[i] = null;
            }
            numberOfItems = 0;
            disposed = true;
        }
        ~Tank()
        {
            Dispose(false);
        }
    }
}
