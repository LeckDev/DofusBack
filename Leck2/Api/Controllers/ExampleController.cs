using Leck2.Business.Managers;
using Leck2.Model.DTOs;
using Leck2.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Leck2.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExampleController : AppController
    {
        private readonly ExampleManager _exampleManager;

        public ExampleController(ILogger<ExampleController> logger, ExampleManager exampleManager) : base(logger)
        {
            _exampleManager = exampleManager;
        }

        [HttpGet]   // GET api/Example
        public async Task<ActionResult<IEnumerable<ExampleDto>>> GetAll()
        {
            IEnumerable<Example> examples = await _exampleManager.GetAllAsync();
            IEnumerable<ExampleDto> exampleDtOs = examples.Select(ExampleDto.FromExample);

            return Ok(exampleDtOs);
        }

        [HttpGet("with-secret")]    // GET api/Example/with-secret
        public async Task<ActionResult<IEnumerable<ExampleWithSecretDto>>> GetAllWithSecret()
        {
            IEnumerable<Example> examples = await _exampleManager.GetAllAsync();
            IEnumerable<ExampleWithSecretDto> exampleDtOs = examples.Select(ExampleWithSecretDto.FromExample);

            return Ok(exampleDtOs);
        }

        [HttpGet("{id}")]   // GET api/Example/12
        public async Task<ActionResult<ExampleDto>> GetById(int id)
        {
            Example? example = await _exampleManager.GetByIdAsync(id);

            if (example == null)
            {
                return NotFound();
            }

            ExampleDto exampleDto = ExampleDto.FromExample(example);
            return Ok(exampleDto);
        }

        [HttpGet("{id}/with-secret")]   // GET api/Example/12/with-secret
        public async Task<ActionResult<ExampleWithSecretDto>> GetByIdWithSecret(int id)
        {
            Example? example = await _exampleManager.GetByIdAsync(id);

            if (example == null)
            {
                return NotFound();
            }

            ExampleWithSecretDto exampleDto = ExampleWithSecretDto.FromExample(example);
            return Ok(exampleDto);
        }

        [HttpPost]  // POST api/Example
        public async Task<IActionResult> Create([FromBody] CreateExampleDto createExampleDto)
        {
            Example example = createExampleDto.ToExample();
            Example createdExample = await _exampleManager.AddAsync(example);

            ExampleWithSecretDto exampleDto = ExampleWithSecretDto.FromExample(createdExample);
            return CreatedAtAction(nameof(GetById), new { id = exampleDto.Id }, exampleDto);
        }

        [HttpPut("{id}")]   // PUT api/Example/12
        public async Task<IActionResult> Update(int id, [FromBody] UpdateExampleDto updateExampleDto)
        {
            if (id != updateExampleDto.Id)
            {
                return BadRequest("L'ID de l'URL ne correspond pas à l'ID dans le corps de la requête.");
            }

            Example example = updateExampleDto.ToExample();
            Example updatedExample = await _exampleManager.UpdateAsync(example);

            ExampleWithSecretDto exampleDto = ExampleWithSecretDto.FromExample(updatedExample);
            return Ok(exampleDto);
        }

        [HttpDelete("{id}")]    // DELETE api/Example/12
        public async Task<IActionResult> Delete(int id)
        {
            Example? example = await _exampleManager.GetByIdAsync(id);

            if (example == null)
            {
                return NotFound();
            }

            await _exampleManager.DeleteAsync(id);
            return NoContent();
        }
    }
}
