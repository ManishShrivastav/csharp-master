// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your name: ");
string? name = Console.ReadLine();
Console.WriteLine($"The reverse of {name} is {ReverseString(name)}");

Console.WriteLine();

public partial class Program
{
    static string ReverseString(string? name)
    {
        string output = "";
        for (int i = name.Length - 1; i >= 0; i--)
        {
            output += name[i];
        }
        return output;
    }
}
