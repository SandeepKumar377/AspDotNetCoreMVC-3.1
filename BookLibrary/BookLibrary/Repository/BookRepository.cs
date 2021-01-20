using BookLibrary.Data;
using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class BookRepository 
    {
        private readonly BookLibraryContext _context = null;
        
        public BookRepository(BookLibraryContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author=model.Author,
                CreatedOn=DateTime.UtcNow,
                Description=model.Description,
                Title=model.Title,
                LanguageId=model.LanguageId,
                TotalPages=model.TotalPages.HasValue ? model.TotalPages.Value : 0,
                UpdatedOn=DateTime.UtcNow
            };

            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            return newBook.Id;

        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            //var books = new List<BookModel>();
            //var allbooks = await  _context.Books.ToListAsync();
            //if(allbooks?.Any()== true)
            //{
            //    foreach(var book in allbooks)
            //    {
            //        books.Add(new BookModel()
            //        { 
            //            Author = book.Author,
            //            Category = book.Category,
            //            Description = book.Description,
            //            Id = book.Id,
            //            LanguageId = book.LanguageId,
            //            TotalPages = book.TotalPages,
            //            Title = book.Title
            //        });
            //    }
            //}
            //return books;

            return await _context.Books
                 .Select(book => new BookModel()
                 {
                     Author = book.Author,
                     Category = book.Category,
                     Description = book.Description,
                     Id = book.Id,
                     LanguageId = book.LanguageId,
                     Language = book.Language.Name,
                     Title = book.Title,
                     TotalPages = book.TotalPages
                 }).ToListAsync();
        }
        public async Task<BookModel> GetBookById(int id)
        {
            //var book =await _context.Books.FindAsync(id);
            //if(book != null)
            //{
            //    var bookDetails = new BookModel()
            //    {
            //        Author = book.Author,
            //        Category = book.Category,
            //        Description = book.Description,
            //        Id = book.Id,
            //        LanguageId = book.LanguageId,
            //        TotalPages = book.TotalPages,
            //        Title = book.Title
            //    };
            //    return bookDetails;
            //}
            //return null;
            return await _context.Books.Where(x => x.Id == id)
                 .Select(book => new BookModel()
                 {
                     Author = book.Author,
                     Category = book.Category,
                     Description = book.Description,
                     Id = book.Id,
                     LanguageId = book.LanguageId,
                     Language = book.Language.Name,
                     Title = book.Title,
                     TotalPages = book.TotalPages
                 }).FirstOrDefaultAsync();
        }
        public List<BookModel> SearchBooks(string title,string authorName)
        {
            return null;
        }        
    }
}
