using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Data
{
    public class BookLibraryContext : DbContext 
    {
        public BookLibraryContext(DbContextOptions<BookLibraryContext> options)
            : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }

        public DbSet<Language> Language { get; set; }

    }
}
