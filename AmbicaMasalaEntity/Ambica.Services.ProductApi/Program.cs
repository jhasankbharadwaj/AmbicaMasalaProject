
using Ambica.Services.ProductApi.Configurations;
using Ambica.Services.ProductApi.Data;
using Ambica.Services.ProductApi.Repository;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Ambica.Services.ProductApi.Repository.IRepository;


namespace Ambica.Services.ProductApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //sql dependency ingition 
            builder.Services.AddDbContext<ProductContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            //  interface dependency injition
            builder.Services.AddTransient<IProductDisplayDtoService, ProductDisplayDtoService>();
            builder.Services.AddTransient<IProductService, ProductService>();

            //AutoMapper injition 
            builder.Services.AddAutoMapper(typeof(AutoMapperConfig).Assembly);


            var app = builder.Build();
            
            // cross origin resource sharing . 
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());// used to 

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
