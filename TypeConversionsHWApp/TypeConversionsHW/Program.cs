

Console.Write("Enter your age: ");

string ageText = Console.ReadLine();

bool isValidAge = int.TryParse(ageText, out int age);

Console.WriteLine($"You are {age} years old. You were {age - 25} years old 25 years ago.");