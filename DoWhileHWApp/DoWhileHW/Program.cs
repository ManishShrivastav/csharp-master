


string formattedName;
string toContinue;

do
{
    Console.Write("What is your name: ");
    string firstName = Console.ReadLine();
    if (firstName.ToLower() == "tim")
    {
        formattedName = $"Professor {firstName}";
        Console.WriteLine($"Welcome {formattedName}");
    }
    else
    {
        formattedName = firstName;
        Console.WriteLine($"Welcome student {formattedName}");
    }
    Console.Write("If you do not wish to continue, type \"yes\" or \"exit\": ");
    toContinue = Console.ReadLine();
} while (toContinue.ToLower() != "exit");

