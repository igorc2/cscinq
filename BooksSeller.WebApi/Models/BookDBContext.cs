using System.Data.Entity;

namespace BooksSeller.WebApi.Models
{
    public class BookDBContext : DbContext
    {
        public BookDBContext()
            : base("name=BookConnectionString")
        {           
        }

        public DbSet<Book> Books { get; set; }
    }
}