using Business.Managers;
using Core.Interfaces.Managers;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;на
using Microsoft.EntityFrameworkCore;
using Data.ApplicationContext;
using Core.Interfaces.Repositories;
using Data.Repository;

namespace WebApplicationLearning
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddScoped(typeof(ICommentManager), typeof(CommentManager));
            builder.Services.AddScoped(typeof(ICommentRepository), typeof(CommentRepository));

            builder.Services.AddDbContext<DbApplicationContext>(
                    options => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Learning;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}