
using Dotnet8webAPI.Entity;
using Dotnet8webAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace Dotnet8webAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //*********************** Add services to the container.***********************
            builder.Services.AddTransient<IOurHeroService, OurHeroService>();
            //*********************** Add services to the container end.***********************

            //*********************** Register DbContext and provide ConnectionString .***********************
            builder.Services.AddDbContext<OurHeroDbContext>(db => db.UseSqlServer(builder.Configuration.GetConnectionString("OurHeroConnectionString")), ServiceLifetime.Singleton);
            //*********************** Register DbContext end.***********************

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
