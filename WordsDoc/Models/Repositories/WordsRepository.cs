using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordsDoc.Services;

namespace WordsDoc.Models.Repositories
{
    public class WordsRepository : IWordsRepository
    {
        private WordsContext context;
        public WordsRepository(WordsContext context)
        {
            this.context = context;
        }

        public void DeleteDefinitionResponce(int wordID)
        {
            DefinisionResponse definisionResponse = context.DefinisionResponses.Find(wordID);
            context.DefinisionResponses.Remove(definisionResponse);
        }

        public DefinisionResponse GetDefinisionResponseByID(int wordId)
        {
            return context.DefinisionResponses.Find(wordId);
        }

        public IEnumerable<DefinisionResponse> GetDefinisionResponses()
        {
            return context.DefinisionResponses.ToList();
        }

        public void InsertDefinitionResponse(DefinisionResponse definisionResponse) => context.DefinisionResponses.Add(definisionResponse);

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateDefinitionResponce(DefinisionResponse definisionResponse)
        {
            context.Entry(definisionResponse).State = EntityState.Modified;
        }

       
    }
}
        
       

