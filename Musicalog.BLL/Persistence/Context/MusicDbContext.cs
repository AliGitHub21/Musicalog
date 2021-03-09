using System;
using Microsoft.EntityFrameworkCore;
using Musicalog.BLL.Extensions;
using Musicalog.DAL.Entities;

namespace Musicalog.BLL.Persistence.Context
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
