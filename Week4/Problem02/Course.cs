using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Course
    {
        public string Name { get; private set; }
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;
        public Course(string name)
        {
            Name = name;
        }
        public void SendHomework(Homework homework)
        {
            OnRaiseCustomEvent(new CustomEventArgs(homework));
        }
        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
