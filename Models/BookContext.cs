using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_api.Models
{

    public class BookContext : DbContext
    {
        //constructor for  DbContextOptions obj to be injected
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            //ensure db is created when using the DbContext  
            Database.EnsureCreated();
        }

        //expose Dbset proprty repr collection of books
        public DbSet<Book> Books { get; set; }
    }
}