using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonAddressPair> people = new List<PersonAddressPair>();
            string firstName = "";

            do
            {
                firstName = RequestData.GetAString("What is your first name (or type exit to stop): ");

                if (firstName.ToLower() != "exit")
                {

                    string lastName = RequestData.GetAString("What is your last name: ");

                    string streetAddress = RequestData.GetAString("What is your street address: ");

                    string city = RequestData.GetAString("What is your city: ");

                    string state = RequestData.GetAString("What is your state: ");

                    string zipCode = RequestData.GetAString("What is your Zip Code: ");

                    PersonAddressPair person = new PersonAddressPair();
                    person.Person.FirstName = firstName;
                    person.Person.LastName = lastName;
                    person.Address.StreetAddress = streetAddress;
                    person.Address.City = city;
                    person.Address.State = state;
                    person.Address.ZipCode = zipCode;
                    people.Add(person);
                }
            } while (firstName.ToLower() != "exit");

            foreach (PersonAddressPair individual in people)
            {
                ProcessPerson.PersonInfo(individual);
            }

            Console.ReadLine();
        }
    }
}
