using AthleteEntity.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleteEntity.Data
{
    internal class SportManagerDbContext : DbContext
    {
        public DbSet<Athlete> Athletes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                connectionString: "Data Source = localhost\\SQLEXPRESS; Initial Catalog = AthleteEntityDB; Integrated Security = true; Trust Server Certificate = true");
            
        }

    }
}
