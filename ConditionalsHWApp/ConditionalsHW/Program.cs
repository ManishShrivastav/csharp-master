

Console.Write("What is your first name: ");

string? firstName = Console.ReadLine();

//if (firstName.ToLower() == "tim" || firstName.ToLower() == "timothy")
//{
//    Console.WriteLine("Welcom Professor Tim.");
//}
//else
//{
//    Console.WriteLine("Welcome Student.d");
//}


switch (firstName.ToLower())
{
    case "tim" or "timothy":
        Console.WriteLine("Welcome Professor Tim.");
        break;
    default:
        Console.WriteLine("Welcome Student");
        break;
}

