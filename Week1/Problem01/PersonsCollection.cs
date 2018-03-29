using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class PersonsCollection
    {
        private List<Person> personsList;
        public PersonsCollection()
        {
            personsList = new List<Person>();
        }
        public void Add(Person person)
        {
            bool sw = true;
            for (int i = 0; (i < personsList.Count) && (sw == true); i++)
                if (personsList.ElementAt(i).CompareWith(person))
                {
                    sw = false;
                }
            if (sw == true)
            {
                personsList.Add(person);
            }
            else
            {
                throw new Exception("Person exist already!");
            }
        }
        public int Count()
        {
            return personsList.Count;
        }
        public Person GetItem(int index)
        {
            if (personsList.ElementAt(index) != null)
            {
                return personsList.ElementAt(index);
            }
            else
            {
                throw new Exception("Element does not exist!");
            }
        }

    }
}
