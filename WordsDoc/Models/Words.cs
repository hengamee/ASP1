using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WordsDoc.Models
{
    public class Words
    {
        [Key]
        [Display(Name = "Enter a Word:")]
        public string Word { get; set; }

        [Display(Name = "Word Definitions:")]
                public string Definition { get; set; }
    }
}
