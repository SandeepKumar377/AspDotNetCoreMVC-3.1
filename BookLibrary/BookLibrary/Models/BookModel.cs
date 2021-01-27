using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BookLibrary.Enums;
using Microsoft.AspNetCore.Http;

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
        [Display(Name ="Choose the cover Photo of your Book!")]
        [Required]

        public IFormFile CoverPhoto { get; set; }

        public string CoverImageUrl { get; set; }

        [Display(Name = "Choose the Gallery Photo of your Book!")]
        [Required]

        public IFormFileCollection GalleryPhoto { get; set; }

        public List<GalleryModel> Gallery { get; set; }

        [Display(Name = "Upload your book in Pdf format!")]
        [Required]

        public IFormFile BookPdf { get; set; }

        public string BookPdfUrl { get; set; }
    }
}
