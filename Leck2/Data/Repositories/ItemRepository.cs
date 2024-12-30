using Leck2.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leck2.Data.Repositories
{
    public class ItemRepository : AppRepository
    {

        public ItemRepository(AppDbContext context, ILogger<ItemRepository> logger) : base(context, logger)
        {
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await Context.Item.ToListAsync();
        }

    }
}
