using ConsoleClient;
using Microsoft.Extensions.DependencyInjection;

namespace Mappings
{
    public class ServiceCollectionInitializer
    {
        public void Initialize(IServiceCollection services)
        {
            services.AddTransient<IPersonManager, PersonManager>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IPersonParser, PersonParser>();
            services.AddTransient<IFileReader, FileReader>();

        }
    }
}
