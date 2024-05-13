

Program.SimpleMethod();

public static partial class Program
{
    private static void SimpleMethod()
    {
        throw new InvalidOperationException("You shold not be calling the SimpleMethod");
    }
}