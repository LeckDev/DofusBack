using Microsoft.AspNetCore.Mvc;

namespace Leck2.Api.Controllers
{
    public abstract class AppController : ControllerBase
    {
        protected readonly ILogger<AppController> Logger;

        protected AppController(ILogger<AppController> logger)
        {
            Logger = logger;
        }
    }
}
