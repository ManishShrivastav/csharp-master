

Dictionary<int, string> employees = new Dictionary<int, string>();
string findEmployee;
bool isValidId;

employees.Add(1, "Tim");
employees.Add(2, "Sue");
employees.Add(3, "Bob");
employees[4] = "Jane";
employees[5] = "Frank";

do
{
    Console.Write("Enter employee ID: ");
    string idText = Console.ReadLine();
    isValidId = int.TryParse(idText, out int id);

    if (isValidId)
    {
        if (employees.ContainsKey(id))
        {
            Console.WriteLine($"Employee name with ID {id}: {employees[id]}");
        }
        else
        {
            Console.WriteLine($"No employee found with ID {id}");
        }
    }
    else
    {
        Console.WriteLine("You didn't provide a valid ID");
    }

    Console.Write("Find another employee? (yes/no): ");
    findEmployee = Console.ReadLine();
} while (findEmployee.ToLower() == "yes");

//do
//{
//    do
//    {
//        Console.Write("Enter employee id: ");
//        string idText = Console.ReadLine();
//        isValidId = int.TryParse(idText, out int id);
//        if (isValidId)
//        {
//            Console.Write("Enter employee name: ");
//            string name = Console.ReadLine();
//            employees.Add(id, name);

//            Console.WriteLine();
//            Console.WriteLine($"The employee with Id {id} is {employees[id]}");
//            Console.WriteLine();
//        }
//        else
//        {
//            Console.WriteLine("You didn't provide a valid id");
//        }
//        Console.Write("Add more employee, yes or no: ");
//        addEmployee = Console.ReadLine();
//    } while (addEmployee.ToLower() != "no");

//    Console.Write("Find another employee, type yes or no: ");
//    findEmployee = Console.ReadLine();

//} while (findEmployee.ToLower() != "no");

