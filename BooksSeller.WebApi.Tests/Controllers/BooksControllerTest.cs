using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BooksSeller.WebApi;
using BooksSeller.WebApi.Controllers;
using BooksSeller.WebApi.Providers;
using BooksSeller.WebApi.Models;
using Moq;
using System.Collections;

namespace BooksSeller.WebApi.Tests.Controllers
{
    [TestClass]
    public class BooksControllerTest
    {
        private Mock<IBooksProvider> _booksProvider;
        private BooksController _booksController;

        [TestInitialize]
        public void Inicialize()
        {
            var bookProvider = new Mock<IBooksProvider>();
            _booksController = new BooksController(bookProvider.Object);
        }


        [TestMethod]
        public void Get()
        {
            var listBook = new List<Book>();

            _booksProvider.Setup(x => x.GetBooks()).Returns(listBook);

            IEnumerable result = booksController.Get();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetById()
        {
            var book = new Book();
            var id = 1;

            _booksProvider.Setup(x => x.GetBook(id)).Returns(book);

            Book result = booksController.Get(id);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Post()
        {

            // Arrange
            var mockRepository = new Mock<IProductRepository>();
            var controller = new Products2Controller(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.Delete(10);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));


            var book = new Book()
            {
                Code = "AAA-9999",
                Title = "Stars Wars",
                ReleaseDate = "12/13/2016",
                Price = 99.9
            };

            _booksProvider.Setup(x => x.SaveBook(book));

            booksController.Post(book);
        }

        [TestMethod]
        public void Put()
        {
            var book = new Book()
            {
                Id = 2,
                Code = "AAA-9999",
                Title = "Stars Wars",
                ReleaseDate = "12/13/2016",
                Price = 99.9
            };

            _booksProvider.Setup(x => x.SaveBook(book.Id, book));

            booksController.Put(book.Id, book);
        }

        [TestMethod]
        public void Delete()
        {
            var id = 1;

            _booksProvider.Setup(x => x.DeleteBook(id));

            booksController.Delete(id);
        }

    }
}