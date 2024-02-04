using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using RESTFulSense.Controllers;
using SozlarJadvali.Models.Words;
using SozlarJadvali.Services.Words;

namespace SozlarJadvali.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class WordController : RESTFulController
    {
        private readonly IWordService wordService;

        public WordController(IWordService wordService)
        {
            this.wordService = wordService;
        }

        [HttpPost("Add-Word")]
        [Authorize]
        public async ValueTask<ActionResult<Word>> PostWord(List<Word> words)
        {
            if (words == null || words.Count == 0)
            {
                return BadRequest("No words provided");
            }

            foreach (var word in words)
            {
                await this.wordService.AddWordAsync(word);
            }

            return Ok(words);
        }

        [HttpGet("Get-All-Words")]
        [EnableQuery]
        public ActionResult<Word> GetAllWords()
        {
            IQueryable<Word> AllWords =
                this.wordService.RetrieveAllWords();

            return Ok(AllWords);
        }

        [HttpPut("Update-Word")]
        [Authorize]
        public async ValueTask<ActionResult<Word>> PutWord(Word word)
        {
            return await this.wordService.ModifyWordAsync(word);
        }

        [HttpDelete("Delete-Word")]
        [Authorize]
        public async ValueTask<ActionResult<Word>> DeleteWord(Guid id)
        {
            Word selectedWord =
                await this.wordService.RetrieveWordByIdAsync(id);

            return await this.wordService.RemoveWordAsync(selectedWord);
        }
    }
}