using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class ProcessPerson
    {
        public static void PersonInfo(PersonAddressPair personAddressPair)
        {
            Console.WriteLine();
            Console.WriteLine(
                $"Your name is {personAddressPair.Person.FirstName} {personAddressPair.Person.LastName} " +
                $"and your address is {personAddressPair.Address.StreetAddress}, " +
                $"{personAddressPair.Address.City}, {personAddressPair.Address.State}, {personAddressPair.Address.ZipCode}.");
        }
    }
}
