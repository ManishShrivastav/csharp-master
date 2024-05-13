// Create a Console Application that has variables to hold a person's name,
// age, if they are alive, and their phone number. You do not need to capture
// these values from the user.

Console.WriteLine("Welcome to our application");
Console.WriteLine();
Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();
Console.Write("What is your last name: ");
string? lastName = Console.ReadLine();
string fullName = $"{firstName} {lastName}";
Console.WriteLine();
Console.WriteLine(fullName);
Console.WriteLine("How old are you: ");
int age;
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"You're {age} years old.");
bool isAlive = true;
Console.WriteLine();
Console.Write("What is your contact number: ");
string? phoneNumber = Console.ReadLine();
Console.WriteLine($"Your contact number is {phoneNumber}");
