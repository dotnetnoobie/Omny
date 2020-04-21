using Microsoft.Extensions.DependencyInjection; 

namespace Omny
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddOmny(this IServiceCollection services)
        {
            return services.AddTransient<IOmnyClient, OmnyClient>();
        }
    }
}