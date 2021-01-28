using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WordsDoc.Models
{
    
    public class DefinisionItem
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public string PartOfSpeech { get; set; }
      
    }
}
