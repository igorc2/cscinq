﻿using System;
using System.Data.Entity;

namespace BooksSeller.WebApi.Models
{
    public class Book
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public double Price { get; set; }
    }

    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}