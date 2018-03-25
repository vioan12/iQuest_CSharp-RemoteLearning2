using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }
        public string dateOfDead { get; set; }
        public Person()
        {
        }
        public bool CompareWith(Person person)
        {
            if (firstName != person.firstName)
            {
                return false;
            }
            if (lastName != person.lastName)
            {
                return false;
            }
            if (dateOfBirth != person.dateOfBirth)
            {
                return false;
            }
            if (dateOfDead != person.dateOfDead)
            {
                return false;
            }
            return true;
        }
    }
}
