using Methods;

//for (int i = 0; i < 10; i++)
//{
//	SampleMethods.SayHi(); 
//}

// DRY - Don't Repeat Yourself
// SOLID - SRP - Single Responsibility Principle

//string name = ConsoleMessages.GetUsersName();

//ConsoleMessages.SayHi(name);

//double result = MathShortcuts.Add(5, 3);
//Console.WriteLine($"The result is {result}");

//double[] vals = new double[] { 2, 5, 6, 21, 52, 98 };
//MathShortcuts.AddAll(vals);

//ConsoleMessages.SayGoodbye();

// Discard character (_)
(string firstName, string _) fullName = ConsoleMessages.GetFullName();
Console.WriteLine($"First Name: {fullName.firstName}");

//(string firstName, string lastName) fullName = ConsoleMessages.GetFullName();
//Console.WriteLine($"First Name: {fullName.firstName}");
//Console.WriteLine($"Last Name: {fullName.lastName}");