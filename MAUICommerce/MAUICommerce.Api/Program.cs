
using MAUICommerce.Api.Constants;
using MAUICommerce.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace MAUICommerce.Api
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

            builder.Services.AddDbContext<DataContext>(optsions => optsions.UseSqlServer(builder.Configuration.GetConnectionString(DatabaseConstants.GroceryConnectionStringKey)));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            var masterGroup = app.MapGroup("/master").AllowAnonymous();
            masterGroup.MapGet("/categories", async (DataContext context) =>
                await context.Categories
                .AsNoTracking()
                .ToArrayAsync());
            masterGroup.MapGet("/offers", async (DataContext context) =>
                await context.Categories
                .AsNoTracking()
                .ToArrayAsync()
             );

            app.Run("https://localhost:12345");
        }
    }
}
