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
        private readonly IWordsRepository _wordsRepository;
        public WordsApiController(IWordsRepository wordsRepository)
        {
            _wordsRepository = wordsRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var records = _wordsRepository.Get();
            if (records != null)
                if (records.Count > 0)
                    return Ok(records);
            return NotFound();
        }
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string word)
        {
            var data = _wordsRepository.GetByWord(word);
            if (data == null)
                return Ok(data);
                return NotFound();
            }
           
        }
       


}
