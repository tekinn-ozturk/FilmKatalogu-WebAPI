using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.BLL.Models.DTOs.FilmDTOs
{
	public class UpdateFilmDTO
	{
        public int Id { get; set; }
        public string FilmAdi { get; set; }
		public string VizyonTarihi { get; set; }


		public int OyuncuId { get; set; }

		public int KategoriId { get; set; }
	}
}
