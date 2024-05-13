

string[] names = new string[3];
names[0] = "Tim";
names[1] = "Bob";
names[2] = "Sue";

bool isValidNumber;
string continueOrNot;

do
{
	Console.Write($"Choose a number between 0 and {names.Length}: ");
	string numberText = Console.ReadLine();
	isValidNumber = int.TryParse(numberText, out int validNumber);
    if (isValidNumber == false || validNumber >= names.Length)
    {
        Console.WriteLine("Please enter a number within the given range.");
    }
    else
    {
        Console.WriteLine($"The person at number {validNumber} in the array is {names[validNumber - 1]}");
    }
    Console.Write("Do you wish to continue (type yes/no): ");
    continueOrNot = Console.ReadLine();
} while (continueOrNot.ToLower() == "yes");
