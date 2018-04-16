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
        private List<HomeworkCourse> homeworkAndCoursesList { get; set; }
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;
        public Student(string name)
        {
            Name = name;
            homeworkAndCoursesList = new List<HomeworkCourse>();
        }
        public void CreateHomework(string homeworkContent, Course course)
        {
            Homework homework = new Homework(homeworkContent);
            HomeworkCourse homeworkCourse = new HomeworkCourse(homework, course);
            homeworkAndCoursesList.Add(homeworkCourse);
        }
        public void SendAllHomework()
        {
            foreach (HomeworkCourse homeworkAndCourse in homeworkAndCoursesList)
            {
                homeworkAndCourse.Course.SendHomework(homeworkAndCourse.Homework);
            }
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
