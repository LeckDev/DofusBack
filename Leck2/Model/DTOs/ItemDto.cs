using Leck2.Model.Entities;

namespace Leck2.Model.DTOs
{
    public class ItemDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int StackAmount { get; set; }

        public Item ToItem()
        {
            Item item = new Item();
            Id = this.Id;
            item.Name = this.Name;
            item.StackAmount = this.StackAmount;

            return item;
        }

        public static ItemDto FromItem(Item item)
        {
            ItemDto dto = new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                StackAmount = item.StackAmount
            };
            return dto;
        }
    }
}
