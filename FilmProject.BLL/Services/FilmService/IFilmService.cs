
using FilmProject.BLL.Models.DTOs.FilmDTOs;
using FilmProject.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.BLL.Services.FilmService
{
	public interface IFilmService
	{
		Task<List<Film>> TumFilmleriGetir();
		Task<Film> IdyeGoreFilmGetir(int id);
		Task<List<Film>> GetAllwithOyuncu();

		//Task Create(Film film);
		Task Create(CreateFilmDTO createfilmDTO);
		Task Update(UpdateFilmDTO updatefilmDTO);
		Task Delete(DeleteFilmDTO deleteFilmDTO);

		
	}
}
