

Console.Write("Enter your name: ");
string firstName = Console.ReadLine();

if (firstName.ToLower() == "tim")
{
    Console.WriteLine("Hello Professor");
}
else
{
    Console.WriteLine("Hello student");
}

switch (firstName.ToLower())
{
    case "tim":
        Console.WriteLine("Hello Professor from switch");
        break;
    default:
        Console.WriteLine("Hello Student from switch");
        break;
}
