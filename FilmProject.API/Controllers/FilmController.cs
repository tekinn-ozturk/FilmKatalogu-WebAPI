using FilmProject.BLL.Models.DTOs.FilmDTOs;
using FilmProject.BLL.Models.DTOs.OyuncuDTOs;
using FilmProject.BLL.Services.FilmService;
using FilmProject.CORE.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmProject.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class FilmController : ControllerBase
	{
		private readonly IFilmService _filmService;
		private object deleteOyuncuDTO;

		public FilmController(IFilmService filmService)
        {
			_filmService = filmService;
		}

		[HttpGet]
		public async Task<IActionResult> TumFilmleriGetir()
		{
			var films = await _filmService.GetAllwithOyuncu();
			if (films.Count>0)
			{
				return Ok(films);
			}
			else if (films.Count==0)
			{
				return BadRequest("Film Bulunamadı!");
			}
			else
			{
				return NotFound();
			}
			
		}

		[HttpGet("id")]
		public async Task<IActionResult> IdyeGoreFilmGetir(int id)
		{
			var film = await _filmService.IdyeGoreFilmGetir(id);
			if (film != null)
			{
				return Ok(film);
			}
			else
			{
				return NotFound();
			}
		}


		[HttpPost]
		public async Task<IActionResult> FilmEkle(CreateFilmDTO createfilmDTO)
		{
			if (ModelState.IsValid)
			{
				 await _filmService.Create(createfilmDTO);
				return Ok(createfilmDTO);
			}
			else
			{
				return BadRequest(404);

			}
			

		}

		[HttpPut("id")]
		public async Task<IActionResult> FilmGuncelle(UpdateFilmDTO updateFilmDTO)
		{
			if (ModelState.IsValid)
			{
				await _filmService.Update(updateFilmDTO);
				return Ok(updateFilmDTO);
			}
			else
			{
				return BadRequest(404);

			}
		}

		[HttpDelete("id")]
		public async Task FilmSil(DeleteFilmDTO deleteFilmDTO)
		{
			await _filmService.Delete(deleteFilmDTO);
		}


		//[HttpPost("FilmİcineOyuncuEkle")]
		//public async Task FilmİcineOyuncuEkle(CreateFilmDTO createfilmDTO)
		//{
		//	await _filmService.Create(createfilmDTO);

		//}







	}
}
