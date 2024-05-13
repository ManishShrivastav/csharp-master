// See https://aka.ms/new-console-template for more information

using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;


SqlCrud sql = new SqlCrud(GetConnectionString());

//ReadAllContacts(sql);

//ReadContact(sql, 3);

//CreateNewContact(sql);

//UpdateContact(sql);

//RemovePhoneNumberFromContact(sql, 3, 1004);

Console.WriteLine("Done Processing SQL Server!!!");

Console.ReadLine();

static void RemovePhoneNumberFromContact(SqlCrud sql, int contactId, int phoneNumberId)
{
    sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
}
static void UpdateContact(SqlCrud sql)
{
    BasicContactModel contact = new BasicContactModel
    {
        Id = 1,
        FirstName = "Timothy",
        LastName = "Corey",
    };
    sql.UpdateContactName(contact);
}

static void CreateNewContact(SqlCrud sql)
{
    FullContactModel user = new FullContactModel
    {
        BasicInfo = new BasicContactModel
        {
            FirstName = "Charity",
            LastName = "Corey"
        }
    };

    user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "nope@aol.com" });
    user.EmailAddresses.Add(new EmailAddressModel { Id = 2, EmailAddress = "me@timothycorey.com" });

    user.PhoneNumbers.Add(new PhoneNumberModel { Id = 1, PhoneNumber = "555-1212" });
    user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-9876" });

    sql.CreateContact(user);
}

static void ReadAllContacts(SqlCrud sql)
{
    var rows = sql.GetAllContacts();

    foreach (var row in rows)
    {
        Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
    }
}

static void ReadContact(SqlCrud sql, int contactId)
{
    var contact = sql.GetFullContactById(contactId);

    Console.WriteLine($"{contact.BasicInfo.Id}: {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");
}

static string GetConnectionString(string connectionStringName = "Default")
{
    string output;

    var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
    var config = builder.Build();

    output = config.GetConnectionString(connectionStringName);

    return output;
}
