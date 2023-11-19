using FilmProject.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.DAL.Context
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
                
        }

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }



	}
}
