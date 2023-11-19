using FilmProject.CORE.Entities;
using FilmProject.CORE.IRepository;
using FilmProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.DAL.Repository
{
	public class KategoriRepository :BaseRepository<Kategori>, IKategoriRepository
	{
        public KategoriRepository(AppDbContext context): base(context)
        {
			
		}
    }
}
