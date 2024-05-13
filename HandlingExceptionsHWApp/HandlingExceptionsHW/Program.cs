

using HandlingExceptionsHW;

try
{
	BadCaller.BadCall();
	}
catch (Exception ex)
{
    Console.WriteLine("There was an exception thrown in our app");
    Console.WriteLine(ex.Message);
}