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
                new BookModel(){Id =1, Title="MVC", Author="Sandeep", Description="This is description for MVC book.", Category="Programing", Language="English", TotalPages=1206},
                new BookModel(){Id =2, Title="Dot Net Core", Author="Sandy", Description="This is description for Dot Net Core book.", Category="Framwork", Language="Hindi", TotalPages=2206},
                new BookModel(){Id =3, Title="C#", Author="Sanjay", Description="This is description for C# book.", Category="Developer", Language="Spanish", TotalPages=1002},
                new BookModel(){Id =4, Title="JAVA", Author="Sandeep", Description="This is description for JAVA book.", Category="Programing", Language="Chines", TotalPages=506},
                new BookModel(){Id =5, Title="PHP", Author="Sandy", Description="This is description for PHP book.", Category="Development", Language="French", TotalPages=906},
                new BookModel(){Id =6, Title="Azure DevOps", Author="Adi", Description="This is description for Azure DevOps book.", Category="DevOps", Language="English", TotalPages=886},
            };
        }
    }
}
