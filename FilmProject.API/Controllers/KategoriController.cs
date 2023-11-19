using FilmProject.BLL.Models.DTOs.FilmDTOs;
using FilmProject.BLL.Models.DTOs.KategoriDTOs;
using FilmProject.BLL.Services.KategoriService;
using FilmProject.CORE.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmProject.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class KategoriController : ControllerBase
	{
		private readonly IKategoriService _kategoriService;

		public KategoriController(IKategoriService kategoriService)
		{
			_kategoriService = kategoriService;
		}

		[HttpGet]
		public async Task<IActionResult> TumKategorileriGetir()
		{
			var kategoriler = await _kategoriService.TumKategorileriGetir();
			if (kategoriler.Count>0)
			{
				return Ok(kategoriler);
			}
			else if(kategoriler.Count==0)
			{
				return BadRequest("Kategori Bulunamadı!");
			}
			else
			{
				return NotFound();
			}
		}

		[HttpGet("id")]
		public async Task<IActionResult> IdyeGoreKategoriGetir(int id)
		{
			var kategori = await _kategoriService.IdyeGoreKategoriGetir(id);
			if (kategori !=null)
			{
				return Ok(kategori);

			}
			else
			{
				return NotFound();
			}
		}

		[HttpPost]
		public async Task KategoriEkle(CreateKategoriDTO createKategoriDTO)
		{
			await _kategoriService.Create(createKategoriDTO);
		}

		[HttpPut("id")]
		public async Task KategoriGuncelle(UpdateKategoriDTO updateKategoriDTO)
		{
			await _kategoriService.Update(updateKategoriDTO);
		}

		[HttpDelete("id")]
		public async Task KategoriSil(DeleteKategoriDTO deleteKategoriDTO)
		{
			await _kategoriService.Delete(deleteKategoriDTO);
		}


	}
}
