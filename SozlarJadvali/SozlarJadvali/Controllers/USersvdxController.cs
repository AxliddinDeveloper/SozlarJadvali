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
    public class USersvdxController : RESTFulController
    {
        private readonly IWordService wordService;

        public USersvdxController(IWordService wordService)
        {
            this.wordService = wordService;
        }


        [HttpGet("Get-All-sdvsdvs")]
        [EnableQuery]
        [EnableCors("AllowSpecificOrigin")]
        public ActionResult<Word> GetAllWords()
        {
            IQueryable<Word> AllWords =
                this.wordService.RetrieveAllWords();

            return Ok(AllWords);
        }
    }
}
