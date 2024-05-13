// Ask the user for their first name. Continue
// asking for first names until there are no more.
// Then loop through each name using foreach and
// tell each person hello on the console.


List<string> firstNames = new List<string>();
string addMoreName;

do
{
	Console.Write("Enter your first name: ");
	string name = Console.ReadLine();

	firstNames.Add(name);

	Console.Write("Do you want to add one more name (type yes/no): ");
	addMoreName = Console.ReadLine();
} while (addMoreName.ToLower() == "yes");

Console.WriteLine();
foreach (string firstName in firstNames)
{
    Console.WriteLine($"Hello {firstName}");
}