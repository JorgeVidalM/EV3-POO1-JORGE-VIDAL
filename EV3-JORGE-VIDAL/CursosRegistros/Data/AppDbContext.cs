using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursosRegistros.Models;
using Microsoft.EntityFrameworkCore; 

namespace CursosRegistros.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=estudiantes.db");
        }
    }
}
