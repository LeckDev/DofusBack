using Leck2.Constants;

public static class CorsConfig
{
    public const string AllowedOriginsNotFound = "Les origines autorisées (AllowedOrigins) n'ont pas été trouvées dans la configuration CORS.";
    public const string AllowedMethodsNotFound = "Les méthodes autorisées (AllowedMethods) n'ont pas été trouvées dans la configuration CORS.";
    public const string AllowedHeadersNotFound = "Les en-têtes autorisés (AllowedHeaders) n'ont pas été trouvés dans la configuration CORS.";
    public const string ConfiguredCorsPolicy = "ConfiguredCorsPolicy";

    public static void AddCorsConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        // Charger les paramètres CORS à partir du fichier de configuration
        IConfigurationSection corsSettings = configuration.GetSection(ConfigurationKeys.CorsSection);

        string[] allowedOrigins = corsSettings.GetSection(ConfigurationKeys.CorsAllowedOriginsKey).Get<string[]>()
                                  ?? throw new InvalidOperationException(AllowedOriginsNotFound);

        string[] allowedMethods = corsSettings.GetSection(ConfigurationKeys.CorsAllowedMethodsKey).Get<string[]>()
                                  ?? throw new InvalidOperationException(AllowedMethodsNotFound);

        string[] allowedHeaders = corsSettings.GetSection(ConfigurationKeys.CorsAllowedHeadersKey).Get<string[]>()
                                  ?? throw new InvalidOperationException(AllowedHeadersNotFound);

        services.AddCors(options =>
        {
            options.AddPolicy(ConfiguredCorsPolicy, policy =>
            {
                policy.WithOrigins(allowedOrigins)
                    .WithMethods(allowedMethods)
                    .WithHeaders(allowedHeaders);
            });
        });
    }
}