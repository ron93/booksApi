

using System.Collections.Generic;
using System.Threading.Tasks;
using book_api.Models;
using Microsoft.EntityFrameworkCore;

namespace book_api.Repositories
{
    public class BookRepository : IBookRepository
    {
        public readonly BookContext _context;
        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public async Task<Book> Create(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return book;
        }

        public async Task Delete(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id);
            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> Get()
        {
            return await _context.Books.ToListAsync();
        }

        public Task<Book> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}