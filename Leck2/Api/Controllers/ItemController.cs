using Leck2.Business.Managers;
using Leck2.Model.DTOs;
using Leck2.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leck2.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : AppController
    {
        private readonly ItemManager _itemManager;

        public ItemController(ILogger<ItemController> logger, ItemManager itemManager) : base(logger)
        {
            _itemManager = itemManager;
        }

        [HttpGet]   // GET api/Item
        public async Task<ActionResult<IEnumerable<ItemDto>>> GetAll()
        {
            IEnumerable<Item> items = await _itemManager.GetAllAsync();
            IEnumerable<ItemDto> itemDtos = items.Select(ItemDto.FromItem);

            return Ok(itemDtos);
        }
    }
}
