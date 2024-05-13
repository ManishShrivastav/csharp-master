// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

namespace DemoLibrary
{
    public class Employee : Person
    {
        public string GetFormerLastName()
        {
            return formerLastName;
        }
    }
}
