using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using StationAPI.Context;

namespace StationAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();

            builder.Services.AddCors();

            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("Myra"));
            });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();


            app.UseCors(cors =>
            {
                cors.WithOrigins("http://localhost:4200", "http://localhost:8000");
                cors.AllowAnyMethod();
                cors.AllowAnyHeader();
            });


            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            if (app.Environment.IsProduction())
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("           ESTOU EM PRODU��O              ");
                Console.WriteLine("==========================================");

                app.UseSwagger();
                app.UseSwaggerUI();

                var service = app.Services.CreateScope();
                var context = service.ServiceProvider.GetService<DataContext>();

                try
                {
                    context.Database.Migrate();
                    Console.WriteLine(context);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}