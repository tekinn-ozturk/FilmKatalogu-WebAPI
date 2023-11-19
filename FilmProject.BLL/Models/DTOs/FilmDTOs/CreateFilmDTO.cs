
using FilmProject.CORE.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.BLL.Models.DTOs.FilmDTOs
{
	public class CreateFilmDTO
	{
		public string FilmAdi { get; set; }
		public string VizyonTarihi { get; set; }

		
        public int OyuncuId { get; set; }
		
		public int KategoriId { get; set; }



    }
}
