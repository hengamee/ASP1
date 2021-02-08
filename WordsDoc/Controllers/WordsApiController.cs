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
        public IEnumerable<DefinisionResponse> GetAll()
        {
            
            return WordsRepo.GetAll();
        }
        [HttpGet("{id}", Name = "GetDefinitionResponse")]
        public IActionResult GetById(string id)
        {
            var item = WordsRepo.Find(id);
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
            WordsRepo.Add(item);
            return CreatedAtRoute("GetDefinitionResponse", new { Controller = "WordsApi", id = item.Definitions }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] DefinisionResponse item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var contactObj = WordsRepo.Find(id);
            if (contactObj == null)
            {
                return NotFound();
            }
            WordsRepo.Update(item);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            WordsRepo.Remove(id);
        }
    }

}
