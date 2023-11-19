using FilmProject.BLL.Models.DTOs.KategoriDTOs;
using FilmProject.BLL.Models.DTOs.OyuncuDTOs;
using FilmProject.CORE.Entities;
using FilmProject.CORE.IRepository;
using FilmProject.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.BLL.Services.OyuncuService
{
	public class OyuncuService : IOyuncuService
	{
		private readonly IOyuncuRepository _oyuncuRepository;
		private readonly IFilmRepository _filmRepository;

		public OyuncuService(IOyuncuRepository oyuncuRepository, IFilmRepository filmRepository)
		{
			_oyuncuRepository = oyuncuRepository;
			_filmRepository = filmRepository;
		}

		public async Task Create(CreateOyuncuDTO createOyuncuDTO)
		{
			int filmId = createOyuncuDTO.FilmId;
			Film film = await _filmRepository.GetById(filmId);
			if (film is not null)
			{
				Oyuncu oyuncu = new()
				{
					AdiSoyadi = createOyuncuDTO.AdiSoyadi,
					Cinsiyet = createOyuncuDTO.Cinsiyet,
					Yas = createOyuncuDTO.Yas,
					Film = film

				};
				await _oyuncuRepository.Create(oyuncu);
			}
			else
			{
				throw new InvalidOperationException("Belirtilen FilmId ile Film bulunamadı.");
			}

		}

		public async Task Delete(DeleteOyuncuDTO deleteOyuncuDTO)
		{
			Oyuncu oyuncu = new()
			{
				Id = deleteOyuncuDTO.Id,

			};
			await _oyuncuRepository.Delete(oyuncu);
		}

		public async Task<Oyuncu> IdyeGoreOyuncuGetir(int id)
		{
			if (id > 0)
			{
				return await _oyuncuRepository.GetById(id);
			}
			else
			{
				throw new Exception("Getirilecek öge bulunamadı!");
			}
		}

		public async Task<List<Oyuncu>> TumOyunculariGetir()
		{
			return await _oyuncuRepository.GetAll();
		}

		public async Task Update(UpdateOyuncuDTO updateOyuncuDTO)
		{
			int filmId = updateOyuncuDTO.FilmId;
			Film film = await _filmRepository.GetById(filmId);
			if (film is not null)
			{
				Oyuncu oyuncu = new()
				{
					AdiSoyadi = updateOyuncuDTO.AdiSoyadi,
					Cinsiyet = updateOyuncuDTO.Cinsiyet,
					Yas = updateOyuncuDTO.Yas,
					Film = film

				};
				await _oyuncuRepository.Update(oyuncu);
			}
			else
			{
				throw new InvalidOperationException("Belirtilen FilmId ile Film bulunamadı.");
			}
		}
	}
}
