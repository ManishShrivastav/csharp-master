// Create a Dictionary list of employee IDs and the name
// that goes with the ID. Fill in a few records. Then ask
// the user for their ID and return their name.

Dictionary<int, string> employees = new Dictionary<int, string>();

employees.Add(1, "Tim");
employees.Add(2, "Sue");
employees.Add(3, "Bob");
employees[4] = "Jane";

Console.Write("Enter your employee ID: ");
string idText = Console.ReadLine();

bool isValidId = int.TryParse(idText, out int id);

if (isValidId)
{
    Console.WriteLine($"The name of the employee with ID {id} is {employees[id]}");
}
else
{
    Console.WriteLine("Provide the correct id in correct number format.");
}
