using Leck2.Business.Managers;

namespace Leck2.Config
{
    public static class BusinessConfig
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ExampleManager>();   // Ajout du manager en tant que scoped service.
            services.AddScoped<ItemManager>();   // Ajout du manager en tant que scoped service.

            return services;
        }
    }
}
