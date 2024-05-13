// See https://aka.ms/new-console-template for more information
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

SqliteCrud sql = new SqliteCrud(GetConnectionString());

//ReadAllContacts(sql);

//ReadContact(sql, 2);

//CreateNewContact(sql);

UpdateContact(sql);
ReadAllContacts(sql);

RemovePhoneNumberFromContact(sql, 1, 1);


Console.WriteLine("Done Processing Sqlite!!!");

Console.ReadLine();

static void RemovePhoneNumberFromContact(SqliteCrud sql, int contactId, int phoneNumberId)
{
    sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
}
static void UpdateContact(SqliteCrud sql)
{
    BasicContactModel contact = new BasicContactModel
    {
        Id = 1,
        FirstName = "Timothy",
        LastName = "Corey",
    };
    sql.UpdateContactName(contact);
}

static void CreateNewContact(SqliteCrud sql)
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

static void ReadAllContacts(SqliteCrud sql)
{
    var rows = sql.GetAllContacts();

    foreach (var row in rows)
    {
        Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
    }
}

static void ReadContact(SqliteCrud sql, int contactId)
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
