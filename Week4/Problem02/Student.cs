using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Student
    {
        public string Name { get; private set; }
        private List<Course> coursesList { get; set; }
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;
        public Student(string name)
        {
            Name = name;
            coursesList = new List<Course>();
        }
        public void SendHomework(Homework homework, Course course)
        {
            course.SendHomework(homework);
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
