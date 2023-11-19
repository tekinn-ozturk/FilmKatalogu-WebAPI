using FilmProject.CORE.IRepository;
using FilmProject.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.DAL.Repository
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		private readonly AppDbContext _context;
		private DbSet<T> table;
        public BaseRepository(AppDbContext context)
        {
			_context = context;
			table = _context.Set<T>();
		}

        public async Task Create(T entity)
		{

			table.Add(entity);
			await _context.SaveChangesAsync();
		}
		
		

		public async Task Delete(T entity)
		{
			table.Remove(entity);
			await _context.SaveChangesAsync();
			
		}

		public async Task<List<T>> GetAll()
		{
			return await table.ToListAsync();
		}
		

		public async Task<T> GetById(int id)
		{
			var result = await table.FindAsync(id);

			return result;

		}

		public async Task Update(T entity)
		{
			table.Update(entity);
			await _context.SaveChangesAsync();
			
		}






		//public BaseRepository(AppDbContext context)
		//      {
		//	_context = context;
		//	table=_context.Set<T>();
		//}
		//      public async Task Create(T entity)
		//{
		//	table.Add(entity);
		//	await _context.SaveChangesAsync();

		//}

		//public void Delete(int id)
		//{
		//	var result = table.Find(id);
		//	table.Remove(result);
		//	_context.SaveChanges();

		//}

		//public List<T> GetAll()
		//{
		//	return table.ToList();
		//}

		//public async Task<T> GetById(int id)
		//{
		//	var result = await table.FindAsync(id);
		//	return result;
		//}

		//public Task Update(T entity)
		//{
		//	throw new NotImplementedException();
		//}
	}
}
