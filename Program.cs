using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CadvancedOpdracht.Data;
using CadvancedOpdracht.Controllers;

namespace CadvancedOpdracht
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<CadvancedOpdrachtContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("CadvancedOpdrachtContext") ?? throw new InvalidOperationException("Connection string 'CadvancedOpdrachtContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            //builder.Services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowSpecificOrigin",
            //        builder =>
            //        {
            //            builder.WithOrigins("https://cloudbnb-df3c1.web.app")
            //                   .AllowAnyHeader()
            //                   .AllowAnyMethod();
            //        });
            //});
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());
            }
         
            app.UseHttpsRedirection();

            app.UseCors("AllowSpecificOrigin");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
