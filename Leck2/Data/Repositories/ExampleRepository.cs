using Leck2.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leck2.Data.Repositories
{
    public class ExampleRepository : AppRepository
    {
        public ExampleRepository(AppDbContext context, ILogger<ExampleRepository> logger) : base(context, logger)
        {
        }

        public async Task<IEnumerable<Example>> GetAllAsync()
        {
            return await Context.Examples.ToListAsync();
        }

        public async Task<Example?> GetByIdAsync(int id)
        {
            return await Context.Examples.FindAsync(id);
        }

        public async Task<Example> AddAsync(Example example)
        {
            Context.Examples.Add(example);
            await Context.SaveChangesAsync();
            return example;
        }

        public async Task<Example> UpdateAsync(Example example)
        {
            Context.Examples.Update(example);
            await Context.SaveChangesAsync();
            return example;
        }

        public async Task DeleteAsync(int id)
        {
            Example? example = await GetByIdAsync(id);
            if (example != null)
            {
                Context.Examples.Remove(example);
                await Context.SaveChangesAsync();
            }
        }
    }
}
