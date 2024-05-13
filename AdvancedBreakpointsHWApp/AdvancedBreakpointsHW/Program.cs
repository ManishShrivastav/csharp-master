

try
{
	for (int i = 1; i < 100; i++)
	{
		if (i == 73)
		{
			throw new Exception("Exception occurred at 73.");
		}
		Console.WriteLine(i);
	}
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


