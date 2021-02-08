using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordsDoc.Services;

namespace WordsDoc.Models.Repositories
{
    public interface IWordsRepository
    {
        void Add(DefinisionResponse item);
        IEnumerable<DefinisionResponse> GetAll();
        DefinisionResponse Find(string Key);
        void Remove(string Id);
        void Update(DefinisionResponse item);

    }
}
