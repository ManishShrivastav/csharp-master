

List<string> firstNames = new List<string>();

firstNames.Add("Tim");
firstNames.Add("Sue");
firstNames.Add("Bob");
firstNames.Add("Jane");
firstNames.Add("Frank");

Console.WriteLine(firstNames[firstNames.Count - 1]);

List<int> ages =  new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);

// List<T> - This is a generic as we choose what that T (type) is going to be.

string data = "Corey,Smith,Jones";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Franklin");