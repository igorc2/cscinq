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

        //public BookDBContext CreateContext()
        //{
        //    var von = new BooksProvider(_dbContext)
        //    von.
        //}

        //public Book Create()
        //{
        //    return new Book();
        //}

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
            _dbContext.Entry(book).State = EntityState.Modified;
        }

        public void DeleteBook(int id)
        {
            _dbContext.Books.Remove(_dbContext.Books.Find(id));
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}