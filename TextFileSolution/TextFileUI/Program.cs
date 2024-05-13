﻿// See https://aka.ms/new-console-template for more information
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;


InitializeConfiguration();
textFile = _config.GetValue<string>("TextFile");

ContactModel user1 = new ContactModel
{
    FirstName = "Tim",
    LastName = "Corey",
    EmailAddresses = new List<string>
    {
        "tim@iamtimcorey.com",
        "me@timothycorey.com"
    },
    PhoneNumbers = new List<string>
    {
        "555-1212",
        "555-1234"
    }
};

ContactModel user2 = new ContactModel
{
    FirstName = "Charity",
    LastName = "Corey",
    EmailAddresses = new List<string>
    {
        "nope@aol.com",
        "me@timothycorey.com"
    },
    PhoneNumbers = new List<string>
    {
        "555-1212",
        "555-9876"
    }
};

//CreateContact(user1);
//CreateContact(user2);
//GetAllContacts();

//UpdateContactFirstName("Timothy");
//GetAllContacts();

//Console.WriteLine(  );

//RemovePhoneNumberFromUser("555-1212");
//GetAllContacts();

RemoveUser();
GetAllContacts();

Console.WriteLine("Done Processing text file");

Console.ReadLine();


public partial class Program
{
    private static IConfiguration _config;
    private static string textFile;
    private static TextFileDataAccess db = new TextFileDataAccess();

    private static void GetAllContacts()
    {
        var contacts = db.ReadAllRecords(textFile);

        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.FirstName} {contact.LastName}"); ;
        }
    }

    private static void CreateContact(ContactModel contact)
    {
        var contacts = db.ReadAllRecords(textFile);

        contacts.Add(contact);

        db.WriteAllRecords(contacts, textFile);
    }

    public static void RemoveUser()
    {
        var contacts = db.ReadAllRecords(textFile);
        contacts.RemoveAt(0);
        db.WriteAllRecords(contacts, textFile);
    }

    public static void RemovePhoneNumberFromUser(string phoneNumber)
    {
        var contacts = db.ReadAllRecords(textFile);
        contacts[0].PhoneNumbers.Remove(phoneNumber);
        db.WriteAllRecords(contacts, textFile);
    }

    private static void UpdateContactFirstName(string firstName)
    {
        var contacts = db.ReadAllRecords(textFile);
        contacts[0].FirstName = firstName;
        db.WriteAllRecords(contacts, textFile);
    }

    private static void InitializeConfiguration()
    {
        var builder = new ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
       _config = builder.Build();
    }
}