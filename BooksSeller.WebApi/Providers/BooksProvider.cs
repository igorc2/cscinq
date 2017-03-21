using BooksSeller.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BooksSeller.WebApi.Providers
{

    

    public class BooksProvider : IBooksProvider
    {


        private BookDBContext _dbContext;

        public BooksProvider(BookDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public BooksProvider()
        {
            
        }

        public List<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetBook(int id)
        {
            return _dbContext.Books.Find(id);
        }
      
        public void SaveBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void SaveBook(int id, Book book)
        {
            _dbContext.Set<Book>().Attach(book);
            _dbContext.Entry(book).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            _dbContext.Books.Remove(_dbContext.Books.Find(id));
            _dbContext.SaveChanges();
        }

    }
}