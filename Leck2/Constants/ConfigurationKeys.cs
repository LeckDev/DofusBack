namespace Leck2.Constants
{
    public static class ConfigurationKeys
    {
        /// <summary>
        /// Key for accessing the Kestrel section in the configuration file.
        /// </summary>
        public const string KestrelSection = "Kestrel";

        // Database

        /// <summary>
        /// Key for accessing the PostgreSQL connection string in the configuration file.
        /// </summary>
        public const string ConnectionStringKey = "DefaultConnection";

        // CORS

        /// <summary>
        /// Key for accessing the CORS section in the configuration file.
        /// </summary>
        public const string CorsSection = "CORS";

        /// <summary>
        /// Key for accessing the allowed origins in the CORS configuration.
        /// </summary>
        public const string CorsAllowedOriginsKey = "AllowedOrigins";

        /// <summary>
        /// Key for accessing the allowed methods in the CORS configuration.
        /// </summary>
        public const string CorsAllowedMethodsKey = "AllowedMethods";

        /// <summary>
        /// Key for accessing the allowed headers in the CORS configuration.
        /// </summary>
        public const string CorsAllowedHeadersKey = "AllowedHeaders";
    }
}
