using Leck2.Model.Entities;
using System.ComponentModel.DataAnnotations;

namespace Leck2.Model.DTOs
{
    public class CreateExampleDto
    {
       
        public string Name { get; set; }

        public string Secret { get; set; }

        /// <summary>
        /// Converts this DTO to an instance of <see cref="Example"/>.
        /// </summary>
        public Example ToExample()
        {
            Example example = new Example
            {
                Name = this.Name,
                Secret = this.Secret
            };
            return example;
        }
    }

    /// <summary>
    /// DTO for updating an existing example. Inherits from <see cref="CreateExampleDto"/> to reuse properties.
    /// </summary>
    public class UpdateExampleDto : CreateExampleDto
    {
        /// <summary>
        /// The ID of the example to update. This field is required.
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Converts this DTO to an instance of <see cref="Example"/>, with the ID included.
        /// </summary>
        public new Example ToExample()
        {
            Example example = base.ToExample();
            example.Id = this.Id;
            return example;
        }
    }

    /// <summary>
    /// DTO for returning an example without the secret.
    /// </summary>
    public class ExampleDto
    {
        /// <summary>
        /// The ID of the example.
        /// </summary>
        public int Id;

        /// <summary>
        /// The name of the example.
        /// </summary>
        public string Name;

        /// <summary>
        /// Creates an instance of <see cref="ExampleDto"/> from an <see cref="Example"/>.
        /// </summary>
        public static ExampleDto FromExample(Example example)
        {
            ExampleDto dto = new ExampleDto
            {
                Id = example.Id,
                Name = example.Name
            };
            return dto;
        }
    }

    /// <summary>
    /// DTO for returning an example with the secret.
    /// </summary>
    public class ExampleWithSecretDto : ExampleDto
    {
        /// <summary>
        /// The secret of the example.
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Creates an instance of <see cref="ExampleWithSecretDto"/> from an <see cref="Example"/>.
        /// </summary>
        public new static ExampleWithSecretDto FromExample(Example example)
        {
            ExampleWithSecretDto dto = new ExampleWithSecretDto
            {
                Id = example.Id,
                Name = example.Name,
                Secret = example.Secret
            };

            return dto;
        }
    }
}
