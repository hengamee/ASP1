using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordsDoc.Services;

namespace WordsDoc.Models.Repositories
{
    public interface IWordsRepository
    {
        IEnumerable<DefinisionResponse> GetDefinisionResponses();
        DefinisionResponse GetDefinisionResponseByID(int wordId);
        void InsertDefinitionResponse(DefinisionResponse definisionResponse);
        void DeleteDefinitionResponce(int wordID);
        void UpdateDefinitionResponce(DefinisionResponse definisionResponse);
        void Save();
     
      
        
    }
}
