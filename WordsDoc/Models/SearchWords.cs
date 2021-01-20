using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WordsDoc.Models
{
    public class SearchWords
    {
       
        [Required(ErrorMessage = "You must enter a word!")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Only text allowed")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Enter a word greater than 2 and lesser than 30 characters!")]
        [Display(Name = "Enter a Word")]
        public string Word { get; set; }
    }
}
