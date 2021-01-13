using BookLibrary.Models;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository= null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data= _bookRepository.GetAllBooks();

            return View(data);
        }

        public ViewResult GetBook(int id)
        {
            var data= _bookRepository.GetBookById(id);
            return View(data);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBooks(bookName, authorName);
        }
    }
}
