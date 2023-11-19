using FilmProject.CORE.Entities;
using FilmProject.CORE.IRepository;
using FilmProject.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.DAL.Repository
{
	public class FilmRepository: BaseRepository<Film>,IFilmRepository
	{
		private readonly AppDbContext context;

		public FilmRepository(AppDbContext context) :base(context) 
        {
			this.context = context;
		}
		public async Task<List<Film>> GetAllwithOyuncu()
		{
			return await context.Filmler.Include(x => x.Oyuncular).ToListAsync(); 
		}
	}
}
