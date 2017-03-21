using BooksSeller.WebApi.Models;
using BooksSeller.WebApi.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BooksSeller.WebApi.Controllers
{

    
    public class BooksController : ApiController
    {
        private IBooksProvider _booksProvider;

        public BooksController(IBooksProvider booksProvider)
        {
            _booksProvider = booksProvider;
        }


        // GET: api/Books
        [HttpGet]
        public List<Book> Get()
        {
            try
            {
                return _booksProvider.GetBooks();
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
        }

        // GET: api/Books/5
        [HttpGet]
        public Book Get(int id)
        {
            try
            {
                return _booksProvider.GetBook(id);
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
        }

        // POST: api/Books
        [HttpPost]
        public void Post([FromBody]Book value)
        {
            try
            {
                _booksProvider.SaveBook(value);
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
        }

        // PUT: api/Books/5
        public void Put(int id, [FromBody]Book value)
        {
            try
            {
                _booksProvider.DeleteBook(id);
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            _booksProvider.SaveBook(id, value);
        }

        // DELETE: api/Books/5
        [HttpDelete]
        public void Delete(int id)
        {
            try
            {
                _booksProvider.DeleteBook(id);
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            
        }
    }
}
