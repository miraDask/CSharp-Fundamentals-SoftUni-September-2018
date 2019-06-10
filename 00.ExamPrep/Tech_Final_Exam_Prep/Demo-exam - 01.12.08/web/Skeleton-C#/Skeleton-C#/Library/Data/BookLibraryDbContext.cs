using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    public class BookLibraryDbContext: DbContext
    {
        public virtual DbSet<Book> Books { get; set; }

        private const string connectionString = @"Server=localhost\SQLEXPRESS;Database=LibraryDb;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
