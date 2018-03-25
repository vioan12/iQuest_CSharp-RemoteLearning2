using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Program
    {
        private static ReadFile readFile;
        private static PersonsCollection personsCollection;
        private static Converter converter;
        public static void Main(string[] args)
        {
            personsCollection = new PersonsCollection();
            List<Person> personsList = new List<Person>();
            List<string> allFileLines = new List<string>();
            readFile = new ReadFile(Constants.fileName);
            converter = new Converter();
            try
            {
                allFileLines = readFile.Read();
                personsList = converter.Convert(allFileLines);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            foreach (Person person in personsList)
            {
                try
                {
                    personsCollection.Add(person);
                }
                catch (Exception exception)
                {
                    System.Console.WriteLine(exception.Message);
                }
            }
            for(int i = 0; i < personsCollection.Count(); i++)
            {
                System.Console.WriteLine(personsCollection.GetItem(i).firstName + " "
                    + personsCollection.GetItem(i).lastName + " ("
                    + personsCollection.GetItem(i).dateOfBirth + "-"
                    + personsCollection.GetItem(i).dateOfDead + ")");
            }
        }
    }
}
