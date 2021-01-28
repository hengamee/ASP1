using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordsDoc.Models;

namespace WordsDoc.Controllers
{
    public class WordsController : Controller
    {
        //GET
        public IActionResult SearchWords()
        {
                var viewModel = new SearchWords();
            return View(viewModel);
            
        }
        //POST
        [HttpPost]
        public IActionResult SearchWords(SearchWords model)
        { if (ModelState.IsValid)
            {
                return RedirectToAction("Words", "WordsDoc", new { word = model.Word });
            }
            return View(model);
        }
        //GET
        public IActionResult Words(string words)
        {
            Words viewModel = new Words();
            return View(viewModel);
        }
    }
}
