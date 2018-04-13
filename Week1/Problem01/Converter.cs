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
            string[] splitLine;
            Person person;
            firstName = lastName = dateOfBirth = dateOfDead = "";
            splitLine = line.Split(';');
            firstName = splitLine[0];
            lastName = splitLine[1];
            dateOfBirth = splitLine[2];
            if(splitLine.Length == 4)
            {
                dateOfDead = splitLine[3];
            }
            person = new Person(firstName, lastName, dateOfBirth, dateOfDead);
            return person;
        }
    }
}
