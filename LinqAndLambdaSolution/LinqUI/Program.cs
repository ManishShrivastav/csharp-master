// See https://aka.ms/new-console-template for more information


using LinqUI;
using LinqUI.Models;

//LabmdaTests();
LinqTests();
Console.WriteLine("Done Processing");
Console.ReadLine();


public partial class Program
{
    private static void LabmdaTests()
    {
        var data = SampleData.GetContactData();

        // var results = data.Where(c => c.Addresses.Count > 1);
        //foreach (var item in results)
        //{
        //    Console.WriteLine($"{item.FirstName} {item.LastName}");
        //}

        //var results = data.Select(x => x.FirstName);
        //foreach (var item in results)
        //{
        //    Console.WriteLine(item);
        ////}

        //var results = data.Take(2);
        //foreach (var item in results)
        //{
        //    Console.WriteLine($"{item.FirstName} {item.LastName}");
        //}

        //var results = data.Skip(2).Take(2);
        //foreach (var item in results)
        //{
        //    Console.WriteLine($"{item.FirstName} {item.LastName}");
        //}

        //var results = data.OrderByDescending(x => x.LastName).ToList();
        //foreach (var item in results)
        //{
        //    Console.WriteLine($"{item.FirstName} {item.LastName}");
        //}
    }

    private static void LinqTests() 
    {
        var contacts = SampleData.GetContactData();
        var addresses = SampleData.GetAddressData();

        //var results = (from c in contacts
        //               where c.Addresses.Count > 1
        //               select c);

        //var results = (from c in contacts
        //               join a in addresses
        //               on c.Id equals a.ContactId
        //               select new { c.FirstName, c.LastName, a.City, a.State });

        //foreach (var item in results)
        //{
        //    Console.WriteLine($"{item.FirstName} {item.LastName} from {item.City}, {item.State}");
        //}

        //var results = (from c in contacts
        //               select new {c.FirstName, c.LastName, Addresses = addresses.Where(x => x.ContactId==c.Id)});

        //foreach (var item in results)
        //{
        //    Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Addresses.Count()}");
        //}

        var results = (from c in contacts
                       select new { c.FirstName, c.LastName, Addresses = addresses.Where(a => c.Addresses.Contains(a.Id)) });

        foreach (var item in results)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Addresses.Count()}");
        }

    }
}
