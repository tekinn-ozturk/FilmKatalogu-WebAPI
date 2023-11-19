using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.CORE.Entities
{
	public class Oyuncu
	{
        public int Id { get; set; }
        public string AdiSoyadi { get; set; }
        public string Cinsiyet { get; set; }
        public int Yas { get; set; }

        //Navigation property
        public Film Film { get; set; }

    }
}
