
string name = "";

try
{
    DifferentMethod();

    Console.Write("What is your name: ");
    name = Console.ReadLine();
    ComplexMethod(name);
    SimpleMethod();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("You should not be calling these methods.");
    Console.WriteLine(ex.Message);
}
catch (NotImplementedException)
{
    Console.WriteLine("You forgot to finish your code!!!!");
}
catch (Exception ex ) when (name.ToLower() == "manish")
{
    Console.WriteLine("You used Manish's name, didn't you?");
    //Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    //Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("I always run");
}

public static partial class Program
{
    private static void SimpleMethod()
    {
        throw new InvalidOperationException("You shold not be calling the SimpleMethod");
    }

    private static void DifferentMethod()
    {
        Console.WriteLine("This is the different method working properly.");
        //throw new NotImplementedException();
    }
    private static void ComplexMethod(string name)
    {
        if (name.ToLower() == "manish")
        {
            throw new InsufficientMemoryException("Manish is too big for this method.");
        }
        else
        {
            throw new ArgumentException("This person isn't Manish.");
        }
    }
}