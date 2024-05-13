

Console.WriteLine("Enter names separated by comma: ");
string name = Console.ReadLine();
string[] names = name.Split(',');

Console.WriteLine();
for (int i = 0; i < names.Length; i++)
{    
    Console.WriteLine($"Hello {names[i]}");
}
