using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("Manish", "Shrivastav");

            person.GenerateEmail("gmail.com",true);

            Console.WriteLine(person.Email);

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public PersonModel()
        {

        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public PersonModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateEmail()
        {
            GenerateEmail("aol.com", false);
        }

        public void GenerateEmail(string domain)
        {
            GenerateEmail(domain, false);
        }

        public void GenerateEmail(bool firstInitalMethod)
        {
            GenerateEmail("aol.com", firstInitalMethod);
        }

        public void GenerateEmail(string domain, bool firstInitalMethod)
        {
            if (firstInitalMethod == true)
            {
                Email = $"{FirstName.Substring(0, 1)}{LastName}@aol.com";
            }
            else
            {
                Email = $"{FirstName}.{LastName}@{domain}";
            }
        }
    }
}
