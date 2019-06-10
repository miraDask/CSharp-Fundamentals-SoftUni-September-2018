namespace TeisterMask.Data
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TeisterMask.Models;

    public class TeisterMaskDbContext : DbContext
    {

        public virtual DbSet<Task> Tasks { get; set; }

        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=TaskListDb;Integrated Security=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

    }
}
