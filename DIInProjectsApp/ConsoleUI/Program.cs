// See https://aka.ms/new-console-template for more information




using ConsoleUI;
using DIDemoLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    services.GetRequiredService<App>().Run();
}
catch (Exception ex)
{
    Console.WriteLine($"An error has ocurred: {ex.Message}");
    Console.ReadLine();
}

public partial class Program
{
    static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
        {
            services
                .AddTransient<IMessages, Messages>()
                .AddTransient<App>();
        });
}
