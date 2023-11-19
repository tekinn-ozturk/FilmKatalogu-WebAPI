using FilmProject.BLL.Models.DTOs.FilmDTOs;
using FilmProject.CORE.Entities;
using FilmProject.CORE.IRepository;
using FilmProject.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.BLL.Services.FilmService
{
	public class FilmService : IFilmService
	{
		private readonly IFilmRepository _filmRepository;
		private readonly IOyuncuRepository _oyuncuRepository;
		private readonly IKategoriRepository _kategoriRepository;

		public FilmService(IFilmRepository filmRepository, IOyuncuRepository oyuncuRepository, IKategoriRepository kategoriRepository)
		{
			_filmRepository = filmRepository;
			_oyuncuRepository = oyuncuRepository;
			_kategoriRepository = kategoriRepository;
		}

		public async Task Create(CreateFilmDTO createFilmDTO)
		{
			//var oyuncu = await _oyuncuRepository.GetById(createFilmDTO.OyuncuId);
			//Film film = new Film();
			//film.FilmAdi = createFilmDTO.FilmAdi;
			//film.VizyonTarihi = createFilmDTO.VizyonTarihi;
			//film.Kategori = new Kategori { Id = createFilmDTO.KategoriId };
			//film.Oyuncular.Add(oyuncu);
			//await _filmRepository.Create(film);

			int oyuncuId = createFilmDTO.OyuncuId;
			Oyuncu oyuncu = await _oyuncuRepository.GetById(oyuncuId);
			int kategoriId = createFilmDTO.KategoriId;
			Kategori kategori = await _kategoriRepository.GetById(kategoriId);
			if (oyuncu != null && kategori != null)
			{
				Film film = new()
				{
					FilmAdi = createFilmDTO.FilmAdi,
					VizyonTarihi = createFilmDTO.VizyonTarihi,
					Kategori = kategori,
				
				};

				film.Oyuncular.Add(oyuncu);
				await _filmRepository.Create(film);
			}
			
			

			

		}



		public async Task Delete(DeleteFilmDTO deleteFilmDTO)
		{
			Film film = new()
			{
				Id = deleteFilmDTO.Id
			};
			await _filmRepository.Delete(film);

		}

		public async Task<List<Film>> GetAllwithOyuncu()
		{
			return await _filmRepository.GetAllwithOyuncu();
		}

		public async Task<Film> IdyeGoreFilmGetir(int id)
		{
			if (id > 0)
			{
				return await _filmRepository.GetById(id);
			}
			else
			{
				throw new Exception("Getirilecek öge bulunamadı!");
			}

		}

		public async Task<List<Film>> TumFilmleriGetir()
		{
			return await _filmRepository.GetAll();
		}

		public async Task Update(UpdateFilmDTO updateFilmDTO)
		{
			//var oyuncu = await _oyuncuRepository.GetById(updateFilmDTO.OyuncuId);

			//Film film = new Film();
			//film.FilmAdi = updateFilmDTO.FilmAdi;
			//film.VizyonTarihi = updateFilmDTO.VizyonTarihi;
			//film.Oyuncular.Add(oyuncu);

			//await _filmRepository.Create(film);

			int oyuncuId = updateFilmDTO.OyuncuId;
			Oyuncu oyuncu = await _oyuncuRepository.GetById(oyuncuId);
			int kategoriId = updateFilmDTO.KategoriId;
			Kategori kategori = await _kategoriRepository.GetById(kategoriId);
			if (oyuncu != null && kategori != null)
			{
				Film film = new()
				{
					Id= updateFilmDTO.Id,
					FilmAdi = updateFilmDTO.FilmAdi,
					VizyonTarihi = updateFilmDTO.VizyonTarihi,
					Kategori = kategori,

				};

				film.Oyuncular.Add(oyuncu);
				await _filmRepository.Update(film);
			}

		}
	}
}
