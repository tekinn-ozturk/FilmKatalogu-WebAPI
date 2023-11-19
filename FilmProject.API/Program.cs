using FilmProject.BLL.Services.FilmService;
using FilmProject.BLL.Services.KategoriService;
using FilmProject.BLL.Services.OyuncuService;
using FilmProject.CORE.IRepository;
using FilmProject.DAL.Context;
using FilmProject.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace FilmProject.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.


			builder.Services.AddDbContext<AppDbContext>(option =>
			{
				option.UseSqlServer(builder.Configuration.GetConnectionString("ConStr"));
			});
			builder.Services.AddTransient<IFilmRepository, FilmRepository>();
			builder.Services.AddTransient<IFilmService, FilmService>();

			builder.Services.AddTransient<IOyuncuRepository, OyuncuRepository>();
			builder.Services.AddTransient<IOyuncuService, OyuncuService>();


			builder.Services.AddTransient<IKategoriRepository, KategoriRepository>();
			builder.Services.AddTransient<IKategoriService, KategoriService>();

			builder.Services.AddControllers();
			

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}