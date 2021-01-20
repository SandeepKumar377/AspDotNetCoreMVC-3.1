using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BookLibrary.Enums;

namespace BookLibrary.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage ="Please enter the Title of your book!")]
        public string Title { get; set; }       
        [Display(Name ="Book Author Name")]
        [Required(ErrorMessage ="Please enter the Author of book name!")]
        public string Author { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public string Category { get; set; }
       // [Required(ErrorMessage ="Please enter the Book Language!")]
        public int LanguageId { get; set; }

        public string Language { get; set; }


        [Required(ErrorMessage = "Please enter the Total Pages!")]
        public int? TotalPages { get; set; }
    }
}
