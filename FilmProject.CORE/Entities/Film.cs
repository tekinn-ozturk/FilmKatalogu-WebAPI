using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.CORE.Entities
{
	public class Film
	{
        public int Id { get; set; }
        public string FilmAdi { get; set; }
        public string VizyonTarihi { get; set; }

        //Navigation Property
        public List<Oyuncu> Oyuncular { get; set; } = new();
        public Kategori Kategori { get; set; }


    }
}
