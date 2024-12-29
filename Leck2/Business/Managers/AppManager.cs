namespace Leck2.Business.Managers
{
    public abstract class AppManager
    {
        protected readonly ILogger<AppManager> Logger;

        protected AppManager(ILogger<AppManager> logger)
        {
            Logger = logger;
        }
    }
}
