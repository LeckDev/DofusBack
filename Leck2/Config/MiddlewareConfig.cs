using Leck2.Api.Middlewares.ErrorHandling;
using Leck2.Constants;

namespace Leck2.Config
{
    public static class MiddlewareConfig
    {
        public static void ConfigureMiddlewares(this WebApplication app)
        {
            Console.WriteLine(ProgramSetupLogs.ConfiguringMiddleware);

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseMiddleware<ErrorHandlingMiddleware>();   // Ajouter le ErrorHandlingMiddleware
            app.UseCors(CorsConfig.ConfiguredCorsPolicy);   // Utiliser CORS dans le pipeline HTTP
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
        }
    }
}
