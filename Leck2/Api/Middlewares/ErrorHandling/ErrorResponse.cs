namespace Leck2.Api.Middlewares.ErrorHandling
{
    public class ErrorResponse
    {
        public int HttpStatusCode { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }
    }
}
