using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordsDoc.Services;

namespace WordsDoc.Models.Repositories
{
    public class WordsRepository : IWordsRepository
    {
        static List<DefinisionResponse> DefinitionResponseList = new List<DefinisionResponse>();
        public void Add(DefinisionResponse item)
        {
            DefinitionResponseList.Add(item);
        }
        public DefinisionResponse Find(string key)
        {
            return DefinitionResponseList
                .Where(e => e.Definitions.Equals(key))
                .SingleOrDefault();
        }

        public IEnumerable<DefinisionResponse> GetAll()
        {
            return DefinitionResponseList;
        }

        public void Remove(string Id)
        {
            var itemToRemove = DefinitionResponseList.SingleOrDefault(r => r.Word == Id);
            if (itemToRemove != null)
                DefinitionResponseList.Remove(itemToRemove);
        }

        public void Update(DefinisionResponse item)
        {
            var itemToUpdate = DefinitionResponseList.SingleOrDefault(r => r.Word == item.Word);
            if (itemToUpdate !=null)
            { 
                itemToUpdate.Word = item.Word;
                itemToUpdate.Definitions = item.Definitions;

                    }
        }

       
    }
       

