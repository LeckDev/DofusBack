using Leck2.Constants;
using Leck2.Data;
using Leck2.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Leck2.Config
{
    public static class DatabaseConfig
    {
        private const string ConnectionStringNotFound = "La chaîne de connexion à la base de données est introuvable ou invalide.";

        public static IServiceCollection AddDatabaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAppDbContext(configuration);
            services.AddRepositories();

            return services;
        }

        public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString(ConfigurationKeys.ConnectionStringKey)
                                      ?? throw new InvalidOperationException(ConnectionStringNotFound);

            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(connectionString));

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ExampleRepository>();

            return services;
        }
    }
}
