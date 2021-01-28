using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WordsDoc.Services;

namespace WordsDoc.Models
{
    
        public class DefinisionResponse
        {
            public int Id { get; set; }
            [JsonPropertyName("word")]
            public string Word { get; set; }
            public DefinisionItem[] Definitions { get; set; }
        }
    }

