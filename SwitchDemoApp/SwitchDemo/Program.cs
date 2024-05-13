

string firstName = "Sue";
int age = 3;

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You should have a job");
        break;
    case >= 66:
        Console.WriteLine("Hopefully you are retired or retiring soon.");
        break;
    default:
        Console.WriteLine("Age was not in an expected range");
        break;
}

//switch (firstName.ToLower())
//{
//    case "sue": // case "tim" or "sue":
//	case "tim":
//        Console.WriteLine("Hello Professor");
//        break;
//    case "manish":
//        Console.WriteLine("Hello Doctor");
//        break;
//    default:
//        Console.WriteLine("I Don't know you");
//		break;
//}
