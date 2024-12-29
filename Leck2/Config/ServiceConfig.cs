using Leck2.Constants;

namespace Leck2.Config
{
    public static class ServiceConfig
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            Console.WriteLine(ProgramSetupLogs.AddingServices);

            services.AddDatabaseServices(configuration);    // Ajouter la couche Data (ajout des repositories en tant que scoped services et du DbContext)
            services.AddBusinessServices(); // Ajouter la couche Business
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddCorsConfiguration(configuration);   // Ajouter le support CORS
        }
    }
}
