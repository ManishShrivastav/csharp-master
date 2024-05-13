using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {
            GetGuestInformation();

            PrintGuestInformation();

            Console.ReadLine();
        }

        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                guest.LastName = GetInfoFromConsole("What is your last name: ");
                guest.Age = GetAgeFromConsole("How old are you: ");
                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
                moreGuestsComing = GetInfoFromConsole("Are more guests coming (yes/no): ");

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }

        private static int GetAgeFromConsole(string message)
        {
            int output;

            Console.Write(message);
            string outputText = Console.ReadLine();
            bool isValidAge = int.TryParse(outputText, out output);

            return output;
        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }
    }
}
