using Leck2.Data.Repositories;
using Leck2.Model.Entities;

namespace Leck2.Business.Managers
{
    public class ItemManager : AppManager
    {

        private readonly ItemRepository _itemRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemManager"/> class.
        /// </summary>
        /// <param name="logger">Logger instance for logging information.</param>
        /// <param name="itemRepository">Repository instance for accessing <see cref="Item"/> data.</param>
        public ItemManager(ILogger<ItemManager> logger, ItemRepository itemRepository) : base(logger)
        {
            _itemRepository = itemRepository;
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _itemRepository.GetAllAsync();
        }
    }
}
