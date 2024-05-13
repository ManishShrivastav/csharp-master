// Add students to a class roster List until
// there are no more students. Then print out
// the count of the students to the Console.

List<string> roster = new List<string>();
string addStudent;

do
{
    Console.Write("Add name of student to roster: ");
    string student = Console.ReadLine();
    roster.Add(student);
    Console.Write("Add more students (type yes/no): ");
    addStudent = Console.ReadLine();
} while (addStudent.ToLower() == "yes");

Console.WriteLine($"The total number of students in the roster is {roster.Count}");