﻿
namespace GuestBookDemo
{
    public static class GuestLogic
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Guest Book App");
            Console.WriteLine("*******************************");
            Console.WriteLine();
        }

        public static string GetPartyName()
        {
            Console.Write("What is your party/group name: ");
            string output = Console.ReadLine();

            return output;
        }

        public static int GetPartySize()
        {
            bool isValidNumber;
            int output;
            do
            {
                Console.Write("How many people are in your party: ");
                string partySizeText = Console.ReadLine();
                isValidNumber = int.TryParse(partySizeText, out output);
                if (!isValidNumber)
                {
                    Console.WriteLine("Please enter a valid number of type integer.");
                }
            } while (isValidNumber == false);

            return output;
        }

        public static bool AskToContinue()
        {
            Console.Write("Are there more guests coming (yes/no): ");
            string continueLooping = Console.ReadLine();
            Console.WriteLine();

            bool output = (continueLooping.ToLower() == "yes");

            return output;
        }

        public static (List<string> guests, int total) GetAllGuests()
        {
            int totalGuest = 0;
            List<string> guests = new List<string>();

            do
            {
                guests.Add(GetPartyName());

                totalGuest += GetPartySize();
            } while (AskToContinue());

            return (guests, totalGuest);
        }

        public static void DisplayGuests(List<string> guests)
        {
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }

            Console.WriteLine();
        }

        public static void DisplayGuestCount(int totalGuests)
        {
            Console.WriteLine("Thank you everyone who attended.");
            Console.WriteLine($"The total guest count for this evening was {totalGuests}.");
        }
    }
}
