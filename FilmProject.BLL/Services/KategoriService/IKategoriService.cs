using FilmProject.BLL.Models.DTOs.FilmDTOs;
using FilmProject.BLL.Models.DTOs.KategoriDTOs;
using FilmProject.CORE.Entities;
using FilmProject.CORE.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.BLL.Services.KategoriService
{
	public interface IKategoriService
	{
		Task<List<Kategori>> TumKategorileriGetir();
		Task<Kategori> IdyeGoreKategoriGetir(int id);
		

		
		Task Create(CreateKategoriDTO createKategoriDTO);
		Task Update(UpdateKategoriDTO updateKategoriDTO);
		Task Delete(DeleteKategoriDTO deleteKategoriDTO);
	}
}
