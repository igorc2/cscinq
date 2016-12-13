using BooksSeller.WebApi.Models;
using System.Collections.Generic;
using System.Web;

namespace BooksSeller.WebApi.Providers
{
    public interface IBooksProvider
    {
        //Book Create();

        Book GetBook(int id);

        List<Book> GetBooks();

        void SaveBook(Book book);

        void SaveBook(int id, Book book);

        void DeleteBook(int id);

        //BookDBContext CreateContext();
    }
}