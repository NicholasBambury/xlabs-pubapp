using xlabs_pubapp.Models;
using xlabs_pubapp.Services;
using Microsoft.EntityFrameworkCore;

namespace xlabs_pubapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IPubService, PubService>();
            builder.Services.AddControllers();
            //builder.Services.AddDbContext<PubDataContext>(opt => opt.UseInMemoryDatabase("PubData"));
            var connectionString = "Data Source=PubData.db";
            builder.Services.AddDbContext<PubDataContext>(opt => opt.UseSqlite(connectionString));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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