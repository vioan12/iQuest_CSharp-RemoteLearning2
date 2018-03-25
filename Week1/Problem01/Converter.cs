using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Converter
    {
        public Converter()
        {
        }
        public List<Person> Convert(List<string> lines)
        {
            List<Person> personsList = new List<Person>();
            foreach (string line in lines)
            {
                personsList.Add(ConvertOneLine(line));
            }
            return personsList;
        }
        private Person ConvertOneLine(string line)
        {
            string firstName, lastName, dateOfBirth, dateOfDead;
            Person person = new Person();
            firstName = lastName = dateOfBirth = dateOfDead = "";
            int i = 0;
            {
                while (!line.ElementAt(i).Equals(';'))
                {
                    firstName = firstName + line.ElementAt(i);
                    i++;
                }
                i++;
                while (!line.ElementAt(i).Equals(';'))
                {
                    lastName = lastName + line.ElementAt(i);
                    i++;
                }
                i++;
                while (!line.ElementAt(i).Equals(';'))
                {
                    dateOfBirth = dateOfBirth + line.ElementAt(i);
                    i++;
                }
                i++;
                while (i < line.Count())
                {
                    dateOfDead = dateOfDead + line.ElementAt(i);
                    i++;
                }
            }
            person.firstName = firstName;
            person.lastName = lastName;
            person.dateOfBirth = dateOfBirth;
            person.dateOfDead = dateOfDead;
            return person;
        }
    }
}
