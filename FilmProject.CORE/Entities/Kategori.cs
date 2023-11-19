using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.CORE.Entities
{
	public class Kategori
	{
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        //Navigation Property 
        public List<Film> Filmler { get; set; } = new();
    }
}
