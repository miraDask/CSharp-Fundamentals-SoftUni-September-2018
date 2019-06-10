using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class BookLibraryDbContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=LibreryDbServer=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;;Trusted_Connection=True;");
        }
    }
}
