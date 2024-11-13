using Microsoft.Extensions.DependencyInjection;

namespace Mappings;

public static class ServiceCollectionExtensions
{
    public static void AddApplicationMappings(this IServiceCollection source)
    {
        new ServiceCollectionInitializer().Initialize(source);
    }
}