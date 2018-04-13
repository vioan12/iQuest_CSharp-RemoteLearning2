using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string DateOfBirth { get; private set; }
        public string DateOfDead { get; private set; }
        public Person(string firstName, string lastName, string dateOfBirth, string dateOfDead)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            DateOfDead = dateOfDead;
        }
        public bool CompareWith(Person person)
        {
            if (FirstName != person.FirstName)
            {
                return false;
            }
            if (LastName != person.LastName)
            {
                return false;
            }
            if (DateOfBirth != person.DateOfBirth)
            {
                return false;
            }
            if (DateOfDead != person.DateOfDead)
            {
                return false;
            }
            return true;
        }
    }
}
