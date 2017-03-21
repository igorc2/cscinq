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
    public class BooksProviderTest
    {
        private Mock<IBooksProvider> _booksProvider;

        [TestInitialize]
        public void Inicialize()
        {
            _booksProvider = new Mock<IBooksProvider>();
        }


        [TestMethod]
        public void Get()
        {
            // Arrange
            var books = new List<Book>();

            // Act
            _booksProvider.Setup(x => x.GetBooks()).Returns(books);

            //Assert
            Assert.IsNotNull(books);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            var book = new Book();
            var id = 1;

            //Act
            _booksProvider.Setup(x => x.GetBook(id)).Returns(book);

            //Assert
            Assert.IsNotNull(book);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            var book = new Book()
            {
                Code = "ABC-1234",
                Title = "Digital Fortress",
                ReleaseDate = "10/10/2011",
                Price = 99.9
            };

            // Act
            _booksProvider.Setup(x => x.SaveBook(book)).;

            //Assert
            _booksController.Post(book);
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            var book = new Book()
            {
                Id = 2,
                Code = "DEF-4321",
                Title = "Demian",
                ReleaseDate = "02/04/1952",
                Price = 99.9
            };

            // Act
            _booksProvider.Setup(x => x.SaveBook(book.Id, book));

            //Assert
            _booksController.Put(book.Id, book);
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            var id = 1;

            // Act
            _booksProvider.Setup(x => x.DeleteBook(id));

            //Assert
            _booksController.Delete(id);
        }

    }
}