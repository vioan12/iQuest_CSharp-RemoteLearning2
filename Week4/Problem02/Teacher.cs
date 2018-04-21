using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Teacher
    {
        public string Name { get; private set; }
        public Teacher(string name, Course course)
        {
            Name = name;
            course.RaiseCustomEvent += HandleCustomEvent;
        }
        private void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(Name + " received this homework: {0}", e.Message.Content);
            CheckHomework(e);
        }
        private void CheckHomework(CustomEventArgs e)
        {
            e.Message.Grade = 3;
            Console.WriteLine(Name + " rated the homework above with grade: {0}", e.Message.Grade);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
