using System.Net.Mime;
using System.Net;
using System.Text.Json;

namespace Leck2.Api.Middlewares.ErrorHandling
{
    public class ErrorHandlingMiddleware
    {
        private const string InternalServerErrorMessage = "Une erreur inconnue est survenue";
        private const string ExceptionNotCaught = "Une erreur non gérée s'est produite lors du traitement de la requête.";

        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ExceptionNotCaught);

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = MediaTypeNames.Application.Json;

                var errorResponse = new ErrorResponse()
                {
                    HttpStatusCode = (int)HttpStatusCode.InternalServerError,
                    Message = InternalServerErrorMessage,
                    Detail = ex.Message
                };

                string jsonResponse = JsonSerializer.Serialize(errorResponse);
                await context.Response.WriteAsync(jsonResponse);
            }
        }
    }
}
