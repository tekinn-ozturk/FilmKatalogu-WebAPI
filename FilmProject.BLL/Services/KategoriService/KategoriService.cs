using FilmProject.BLL.Models.DTOs.KategoriDTOs;
using FilmProject.CORE.Entities;
using FilmProject.CORE.IRepository;
using FilmProject.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.BLL.Services.KategoriService
{
	public class KategoriService : IKategoriService
	{
		private readonly IKategoriRepository _kategoriRepository;

		public KategoriService(IKategoriRepository kategoriRepository)
        {
			_kategoriRepository = kategoriRepository;
		}
        public async Task Create(CreateKategoriDTO createKategoriDTO)
		{
			Kategori kategori = new Kategori()
			{
				KategoriAdi = createKategoriDTO.KategoriAdi
			};
			await _kategoriRepository.Create(kategori);

		}

		public async Task Delete(DeleteKategoriDTO deleteKategoriDTO)
		{
			Kategori kategori = new()
			{
				Id = deleteKategoriDTO.Id,
			
			};
			await _kategoriRepository.Delete(kategori);
		}

		public async Task<Kategori> IdyeGoreKategoriGetir(int id)
		{
			if (id > 0)
			{
				return await _kategoriRepository.GetById(id);
			}
			else
			{
				throw new Exception("Getirilecek öge bulunamadı!");
			}
		}

		public async Task<List<Kategori>> TumKategorileriGetir()
		{
			return await _kategoriRepository.GetAll();
		}

		public async Task Update(UpdateKategoriDTO updateKategoriDTO)
		{
			Kategori kategori = new()
			{
				Id = updateKategoriDTO.Id,
				KategoriAdi = updateKategoriDTO.KategoriAdi
			};
			await _kategoriRepository.Update(kategori);
		}
	}
}
