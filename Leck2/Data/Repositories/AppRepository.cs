namespace Leck2.Data.Repositories
{
    public abstract class AppRepository
    {

        protected readonly AppDbContext Context;

        protected readonly ILogger<AppRepository> Logger;

        protected AppRepository(AppDbContext context, ILogger<AppRepository> logger)
        {
            Context = context;
            Logger = logger;
        }
    }
}
