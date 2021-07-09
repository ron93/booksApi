using book_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_api.Repositories
{
    public interface IBookRepository
    {
        //get all books
        Task<IEnumerable<Book>> Get();
        //get one book
        Task<Book> Get(int id);
        //create a book
        Task<Book> Create(Book book);
        //update a book
        Task Update(Book book);
        //delete a book
        Task Delete(int id);
        
        
    }
}