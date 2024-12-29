using Leck2.Data.Repositories;
using Leck2.Model.Entities;

namespace Leck2.Business.Managers
{
    /// <summary>
    /// Manages operations related to the <see cref="Example"/> entity, including CRUD functionality.
    /// </summary>
    public class ExampleManager : AppManager
    {
        private readonly ExampleRepository _exampleRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleManager"/> class.
        /// </summary>
        /// <param name="logger">Logger instance for logging information.</param>
        /// <param name="exampleRepository">Repository instance for accessing <see cref="Example"/> data.</param>
        public ExampleManager(ILogger<ExampleManager> logger, ExampleRepository exampleRepository) : base(logger)
        {
            _exampleRepository = exampleRepository;
        }

        /// <summary>
        /// Retrieves all <see cref="Example"/> entities.
        /// </summary>
        /// <returns>A collection of <see cref="Example"/> objects.</returns>
        public async Task<IEnumerable<Example>> GetAllAsync()
        {
            return await _exampleRepository.GetAllAsync();
        }

        /// <summary>
        /// Retrieves a specific <see cref="Example"/> entity by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the <see cref="Example"/> to retrieve.</param>
        /// <returns>The <see cref="Example"/> entity, or <see langword="null"/> if not found.</returns>
        public async Task<Example?> GetByIdAsync(int id)
        {
            return await _exampleRepository.GetByIdAsync(id);
        }

        /// <summary>
        /// Adds a new <see cref="Example"/> entity to the data store.
        /// </summary>
        /// <param name="example">The <see cref="Example"/> entity to add.</param>
        /// <returns>The added <see cref="Example"/> entity.</returns>
        public async Task<Example> AddAsync(Example example)
        {
            return await _exampleRepository.AddAsync(example);
        }

        /// <summary>
        /// Updates an existing <see cref="Example"/> entity in the data store.
        /// </summary>
        /// <param name="example">The <see cref="Example"/> entity to update.</param>
        /// <returns>The updated <see cref="Example"/> entity.</returns>
        public async Task<Example> UpdateAsync(Example example)
        {
            return await _exampleRepository.UpdateAsync(example);
        }

        /// <summary>
        /// Deletes an <see cref="Example"/> entity by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the <see cref="Example"/> to delete.</param>
        /// <returns>A task representing the asynchronous delete operation.</returns>
        public async Task DeleteAsync(int id)
        {
            await _exampleRepository.DeleteAsync(id);
        }
    }
}