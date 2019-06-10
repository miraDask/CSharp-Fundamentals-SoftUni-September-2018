using BandRegister.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandRegister.Data
{
    public class BandRegisterDbContext : DbContext
    {
        public virtual DbSet<Band> Bands { get; set; }

        private const string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
