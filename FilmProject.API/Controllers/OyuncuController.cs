using FilmProject.BLL.Models.DTOs.KategoriDTOs;
using FilmProject.BLL.Models.DTOs.OyuncuDTOs;
using FilmProject.BLL.Services.OyuncuService;
using FilmProject.CORE.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmProject.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class OyuncuController : ControllerBase
	{
		private readonly IOyuncuService _oyuncuService;

		public OyuncuController(IOyuncuService oyuncuService)
		{
			_oyuncuService = oyuncuService;
		}
		[HttpGet]
		public async Task<IActionResult> TumOyunculariGetir()
		{
			var oyuncular = await _oyuncuService.TumOyunculariGetir();
			if (oyuncular.Count > 0)
			{
				return Ok(oyuncular);
			}
			else if (oyuncular.Count == 0)
			{
				return BadRequest("Oyuncu Bulunamadı!");
			}
			else
			{
				return NotFound();
			}
		}

		[HttpGet("id")]
		public async Task<IActionResult> IdyeGoreOyuncuGetir(int id)
		{
			var oyuncu = await _oyuncuService.IdyeGoreOyuncuGetir(id);
			if (oyuncu != null)
			{
				return Ok(oyuncu);

			}
			else
			{
				return NotFound();
			}
		}
		[HttpPost]
		public async Task OyuncuEkle(CreateOyuncuDTO createOyuncuDTO)
		{
			await _oyuncuService.Create(createOyuncuDTO);
		}

		[HttpPut("id")]
		public async Task OyuncuGuncelle(UpdateOyuncuDTO updateOyuncuDTO)
		{
			await _oyuncuService.Update(updateOyuncuDTO);
		}

		[HttpDelete("id")]
		public async Task OyuncuSil(DeleteOyuncuDTO deleteOyuncuDTO)
		{
			await _oyuncuService.Delete(deleteOyuncuDTO);
		}
	}
}
