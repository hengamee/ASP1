using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WordsDoc.Services
{
  
    public class WordApiService
    {
        private readonly HttpClient _httpClient;

        public WordApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<DefinisionResponse> GetByDefinitionAsync(string word, CancellationToken cancellationToken=default)
        {
            var response = await _httpClient.GetAsync($"{word}/definitions");
            
            if (!response.IsSuccessStatusCode)
                throw new Exception("cannot read data");

            return await response.Content.ReadFromJsonAsync<DefinisionResponse>();
        }

    }

    public class DefinisionResponse
    {
        [JsonPropertyName("word")]
        public string WordId { get; set; }
        public DefinisionItem[] Definitions { get; set; }
    }
    [Keyless]
    public class DefinisionItem
    {
        public string Definition { get; set; }
        public string PartOfSpeech { get; set; }
    }
   
}
