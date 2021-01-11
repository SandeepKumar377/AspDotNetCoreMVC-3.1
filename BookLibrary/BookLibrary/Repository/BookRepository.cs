using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBooks(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id =1, Title="MVC", Author="Sandeep"},
                new BookModel(){Id =2, Title="Dot Net Core", Author="Sandy"},
                new BookModel(){Id =3, Title="C#", Author="Sanjay"},
                new BookModel(){Id =4, Title="JAVA", Author="Sandeep"},
                new BookModel(){Id =5, Title="PHP", Author="Sandy"},
            };
        }
    }
}
