
using MAUICommerce.Api.Constants;
using MAUICommerce.Api.Data;
using MAUICommerce.Api.Data.Entities;
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
                 TypedResults.Ok(await context.Categories
                .AsNoTracking()
                .ToArrayAsync()
                )
            );
            masterGroup.MapGet("/offers", async (DataContext context) =>
                TypedResults.Ok(await context.Categories
                .AsNoTracking()
                .ToArrayAsync()
                )
             );

            app.MapGet("/popular-product", async (DataContext context, int? count) =>
            {
                if (!count.HasValue || count <= 0)
                    count = 6;
                var randomProduct = await context.Products
                                        .AsNoTracking()
                                        .OrderBy(p => Guid.NewGuid())
                                        .Take(count.Value)
                                        .Select(Product.DtoSelector)
                                        .ToArrayAsync();
                return TypedResults.Ok(randomProduct);
            });

            app.Run("https://localhost:12345");
        }
    }
}
