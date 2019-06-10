namespace GameStore.Data
{
    using GameStore.Models;
    using Microsoft.EntityFrameworkCore;
    using System;


    public class GameStoreDbContext : DbContext
    {
        public virtual DbSet<Game> Games { get; set; }

        private const string connectionString = @"Server=DESKTOP-2HCAHJD\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
