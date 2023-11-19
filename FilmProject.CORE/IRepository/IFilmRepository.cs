using FilmProject.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.CORE.IRepository
{
	public interface IFilmRepository : IBaseRepository<Film>
	{

		Task<List<Film>> GetAllwithOyuncu();
	}
}
