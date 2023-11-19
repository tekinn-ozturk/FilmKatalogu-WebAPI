using FilmProject.BLL.Models.DTOs.KategoriDTOs;
using FilmProject.BLL.Models.DTOs.OyuncuDTOs;
using FilmProject.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.BLL.Services.OyuncuService
{
	public interface IOyuncuService
	{
		Task<List<Oyuncu>> TumOyunculariGetir();
		Task<Oyuncu> IdyeGoreOyuncuGetir(int id);



		Task Create(CreateOyuncuDTO createOyuncuDTO);
		Task Update(UpdateOyuncuDTO updateOyuncuDTO);
		Task Delete(DeleteOyuncuDTO deleteOyuncuDTO);
	}
}
