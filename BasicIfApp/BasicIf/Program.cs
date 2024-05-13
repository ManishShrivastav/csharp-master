

//bool isComplete = false;

//if (isComplete)
//{
//    Console.WriteLine("The statement was true.");
//    Console.WriteLine("This line works in true.");
//}
//else
//{
//    Console.WriteLine("The statement was false.");
//    Console.WriteLine("This should also run.");
//}

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "tim")
{
    Console.WriteLine("Hello Mr. Corey");
}
else
{
    Console.WriteLine($"Hello {firstName}");
}

Console.WriteLine("End of program.");