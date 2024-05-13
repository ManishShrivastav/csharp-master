// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

namespace DemoLibrary
{
    public class DataAccess
    {
        protected internal string GetConnectionString()
        {
            return "Sensitive Information";
        }
    }
}
