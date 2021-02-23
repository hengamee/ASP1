using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordsDoc.Models;
using WordsDoc.Models.Repositories;

namespace WordsDoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordsApiController : ControllerBase
    {
        public IWordsRepository WordsRepo { get; set; }
        public WordsApiController(IWordsRepository _repo)
        {
            WordsRepo = _repo;
        }
        [HttpGet]
        public IEnumerable<DefinisionResponse> GetDefinitionResponse()
        {
            
            return WordsRepo.GetDefinisionResponses();
        }
        [HttpGet("{id}", Name = "GetDefinitionResponse")]
        public IActionResult GetById(int Id)
        {
            var item = WordsRepo.GetDefinisionResponseByID(Id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
           [HttpPost]
           public IActionResult Create([FromBody] DefinisionResponse item)
        { 
            if(item==null){
                return BadRequest();
            }
            WordsRepo.InsertDefinitionResponse(item);
            return CreatedAtRoute("GetDefinitionResponse", new { Controller = "WordsApi", id = item.Definitions }, item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int wordId)
        {
            WordsRepo.DeleteDefinitionResponce(wordId);
            return new NoContentResult();
        }
    }

}
