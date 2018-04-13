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
        public bool Add(Person person)
        {
            bool condition = true;
            for (int i = 0; (i < personsList.Count) && (condition == true); i++)
                if (personsList.ElementAt(i).CompareWith(person))
                {
                    condition = false;
                }
            if (condition == true)
            {
                personsList.Add(person);
                return true;
            }
            else
            {
                return false;
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
                return null;
            }
        }

    }
}
