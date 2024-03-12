using GameShopSwaggerUI.Data;
using GameShopSwaggerUI2.Interfaces;
using GameShopSwaggerUI2.Services;
using Microsoft.EntityFrameworkCore;

namespace GameShopSwaggerUI2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("Undefined");
            builder.Services.AddDbContext<ApplicationContext>(op =>
            {
                op.UseSqlServer(connectionString);
            });

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IGameService, GameService>();

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapControllers();
            app.Run();


        }
    }
}