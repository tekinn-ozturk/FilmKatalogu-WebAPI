using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.BLL.Models.DTOs.OyuncuDTOs
{
	public class CreateOyuncuDTO
	{
        public string AdiSoyadi { get; set; }
        public string Cinsiyet { get; set; }
        public int Yas { get; set; }
        public int FilmId { get; set; }
    }
}
