using Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();

            serviceCollection.AddApplicationMappings();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var commands = serviceProvider.GetRequiredService<IPersonDisplayCommands>();

            commands.DisplayAllAdults();

            commands.DisplayAllChildren();
        }
    }
}
