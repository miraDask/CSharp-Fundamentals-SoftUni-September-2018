using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class ToDoDbContext : DbContext
    {
        public virtual DbSet<Task> Tasks { get; set; }

        private const string ConnectinString = @"Server = .\SQLEXPRESS; Database = ToDoListDb; Integrated Security = True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectinString);
        }
    }
}
