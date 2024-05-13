

string keepGoing;
do
{
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    if (name.ToLower() == "tim")
    {
        Console.WriteLine("Welcome Professor");
    }
    else
    {
        Console.WriteLine("Welcome Student.");
    }

    Console.Write("Do you wish to contine (type \"exit\" to discontinue): ");
    keepGoing = Console.ReadLine();
} while (keepGoing.ToLower() != "exit");