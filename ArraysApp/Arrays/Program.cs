

// 0 - based counting - 0, 1, 2, 3, 4
// 1 - based counting - 1, 2, 3, 4, 5

//string[] firstNames = new string[5];

//firstNames[0] = "Tim";
//firstNames[1] = "Sue";
//firstNames[2] = "Bob";
//firstNames[4] = "Jane";

//Console.WriteLine($"The firstNames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]}");
//firstNames[0] = "Timothy";
//Console.WriteLine(firstNames[0]);

//firstNames[5] = "Robert";


// Double quotes idendtifies a string

string data = "Tim,Sue,Bob,Jane,Frank";

string[] firstNames = data.Split(',');

Console.WriteLine(firstNames[1]);

Console.WriteLine(firstNames.Length);

string[] lastNames = new string[] { "Corey", "Smith", "Jones"};

int[] ages = new int[] { 1, 2, 3 };