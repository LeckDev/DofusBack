using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Leck2.Model.Entities
{
    public class Example
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The name of the example. This field is required.
        /// </summary>
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(20, ErrorMessage = "Name must not exceed 20 characters.")]
        public string Name { get; set; }

        /// <summary>
        /// The secret of the example. This field is required.
        /// </summary>
        [Required(ErrorMessage = "Secret is required.")]
        [StringLength(255, ErrorMessage = "Secret must not exceed 255 characters.")]
        public string Secret { get; set; }
    }
}
