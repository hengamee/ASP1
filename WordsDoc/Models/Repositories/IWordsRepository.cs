using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordsDoc.Services;

namespace WordsDoc.Models.Repositories
{
    public interface IWordsRepository
    {
        List<DefinisionResponse> Get();
        DefinisionResponse GetByWord(string Word);
    }
}
