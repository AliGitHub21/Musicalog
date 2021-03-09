using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Musicalog.BLL.Interfaces;
using Musicalog.BLL.Persistence.Context;
using Musicalog.BLL.Repositories;

namespace Musicalog.Presentation.Extensions
{
    public static class StartupExtensionService
    {
        public static void ConfigureUnitOfWork(this IServiceCollection services) 
        { 
            services.AddDbContext<MusicDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>(); 
        }
    }
}