using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordsDoc.Services;

namespace WordsDoc.Models.Repositories
{
    public class WordsRepository : IWordsRepository
    {
        private readonly List<DefinisionResponse> DefinitionResponse1 = new List<DefinisionResponse>();
        public WordsRepository()
        {
            DefinisionResponse definisionResponse = new DefinisionResponse();
            definisionResponse.Word = "";
            DefinitionResponse1.Add(definisionResponse);
        }
        public List<DefinisionResponse> Get()
        {
          
            return null;
        }

        public DefinisionResponse GetByWord(string Word)
        {
            return null;
        }
    }
}
