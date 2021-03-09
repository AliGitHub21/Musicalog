using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Musicalog.BLL.Interfaces;
using Musicalog.BLL.Persistence.Context;
using Musicalog.BLL.Repositories;

namespace Musicalog.BLL.Extensions
{
    public static class StartupExtensionService
    {
        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MusicDbContext>
        {
            public MusicDbContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var builder = new DbContextOptionsBuilder<MusicDbContext>();

                var connectionString = configuration.GetConnectionString("DefaultConnection");

                builder.UseSqlServer(connectionString);       

                return new MusicDbContext(builder.Options);
            }
        }
        // public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config) 
        // {
        //     services.AddDbContext<MusicDbContext>(options =>
        //         options.UseSqlServer(
        //             config.GetConnectionString("DefaultConnection"),
        //             b => b.MigrationsAssembly(typeof(MusicDbContext).Assembly.FullName)));
        // }

        public static void ConfigureUnitOfWork(this IServiceCollection services) 
        { 
            services.AddDbContext<MusicDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>(); 
        }
    }
}