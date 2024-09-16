using Microsoft.AspNetCore.Mvc;
using Vocap.API.Application.Commands;
using Vocap.API.Application.Queries;

namespace Vocap.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VocabularyController : ControllerBase
    {
        private IMediator mediator;
        private IVocabularyQueries queries;
        public VocabularyController(IMediator mediator, IVocabularyQueries queries)
        {
            this.mediator = mediator;
            this.queries = queries;
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewVocap([FromBody] CreateVocabularyRequest request)
        {
            var createdCommand = new CreateVocabularyCommand
                (desc: request.Desc, name: request.Name);
            await mediator.Send(createdCommand);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetVocabulary([FromQuery] string word)
        {
            var values = await queries.GetVocabularyAsync(word);
            return Ok(values);  
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string word)
        {
            var values = await queries.SearchWork(word);
            return Ok(values);

        }
    }
}
public record CreateVocabularyRequest(
    string Name, string Desc);