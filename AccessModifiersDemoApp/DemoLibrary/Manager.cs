// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

namespace DemoLibrary
{
    public class Manager : Employee
    {
        public string GetAllNames()
        {
            return $"{FirstName}, {LastName}, {formerLastName}";
        }
    }
}
