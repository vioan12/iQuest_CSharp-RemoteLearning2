using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(Homework homework)
        {
            this.homework = homework;
        }
        private Homework homework;
        public Homework Message
        {
            get { return homework; }
            set { homework = value; }
        }
    }
}
