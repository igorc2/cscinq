using BooksSeller.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksSeller.WebApi.Providers
{
    public class BooksProvider : IBooksProvider
    {
        private readonly BookDBContext _dbContext;

        public BooksProvider(BookDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Book Create()
        {
            return new Book();
        }

        public List<Book> GetBooks()
        {
            var bb = new Book
            {
                Code = "oi",
                ReleaseDate = "trem",
                Title = "tt",
                Price = 12
            };

            return new List<Book>();
        }

        public Book GetBook(int id)
        {
            return new Book();
        }

      
        public void SaveBook(Book book)
        {
        
        }

        public void SaveBook(int id, Book book)
        {

        }

        public void DeleteBook(int id)
        {

        }


    }
}