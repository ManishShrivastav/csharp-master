using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethoHW
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.SetDefaultAge().PrintInfo("Manish", "Shrivastav");

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public static class ExtensionMethods
    {
        public static PersonModel PrintInfo(this PersonModel person, string firstName, string lastName)
        {
            person.FirstName = firstName;
            person.LastName = lastName;
            Console.WriteLine($"{firstName} {lastName} is {person.Age} years old.");
            return person;
        }

        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = 35; 
            return person;
        }


    }
}
