using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class HomeworkCourse
    {
        public Homework Homework { get; private set; }
        public Course Course { get; private set; }
        public HomeworkCourse(Homework homework, Course course)
        {
            Homework = homework;
            Course = course;
        }
    }
}
