// Ask the user for a comma-separated list of first names (no spaces).
// Split the string into a string array. Loop through the array and
// print "Hello <name>" to the console for each person.

Console.Write("Give me a comma-sparated list of first names (no-spaces): ");
string names = Console.ReadLine();
Console.WriteLine();

string[] firstNames = names.Split(',');

for (int i = 0; i < firstNames.Length; i++)
{
    Console.WriteLine($"Hello {firstNames[i]}!");
}