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
        [Display(Name = "Book Title")]
        public string Title { get; set; }       

        [Display(Name ="Book Author Name")]
        [Required(ErrorMessage ="Please enter the Author of book name!")]
        public string Author { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public string Category { get; set; }

        [Required(ErrorMessage = "Please select the book language!")]
        [Display(Name = "Book Language")]
        public int LanguageId { get; set; }

        public string Language { get; set; }

        [Required(ErrorMessage = "Please enter the Total Pages!")]
        [Display(Name = "Total Pages")]
        public int? TotalPages { get; set; }

        [Display(Name = "Book Cover Image")]
        [Required(ErrorMessage = "Please choose the Cover Image of your book!")]
        public IFormFile CoverPhoto { get; set; }

        public string CoverImageUrl { get; set; }

        [Display(Name = "Book Gallery Image")]
        [Required(ErrorMessage = "Please choose the Gallery Images of your Book!")]
        public IFormFileCollection GalleryPhoto { get; set; }

        public List<GalleryModel> Gallery { get; set; }

        [Display(Name = "Book PDF")]
        [Required(ErrorMessage = "Please Upload your book in Pdf format!")]
        public IFormFile BookPdf { get; set; }

        public string BookPdfUrl { get; set; }
    }
}
