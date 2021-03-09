using Microsoft.EntityFrameworkCore;
using Musicalog.DAL.Entities;

namespace Musicalog.BLL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                new Album { Id = 1, Name = "What is Going On", Artist = "Marvin Gaye" ,Label = "label1", Type = "vinyl", Stock = 2 },
                new Album { Id = 2, Name = "Pet Sounds", Artist = "The Beach Boys" ,Label = "label1", Type = "CD", Stock = 5 },
                new Album { Id = 3, Name = "Blue", Artist = "Joni Mitchell" ,Label = "label1", Type = "vinyl", Stock = 4 },
                new Album { Id = 4, Name = "Songs in the Key of Life", Artist = "Stevie Wonder" ,Label = "label1", Type = "CD", Stock = 13 },
                new Album { Id = 5, Name = "Abbey Road", Artist = "The Beatles" ,Label = "label1", Type = "CD", Stock = 0 },
                new Album { Id = 6, Name = "Never mind", Artist = "Nirvana" ,Label = "label1", Type = "vinyl", Stock = 8 },
                new Album { Id = 7, Name = "Rumours", Artist = "Fleetwood Mac" ,Label = "label1", Type = "CD", Stock = 9 },
                new Album { Id = 8, Name = "Purple Rain", Artist = "Prince and the Revolution" ,Label = "label1", Type = "vinyl", Stock = 2 },
                new Album { Id = 9, Name = "Blood on the Tracks", Artist = "Bob Dylan" ,Label = "label1", Type = "CD", Stock = 3 },
                new Album { Id = 10, Name = "The Medication ", Artist = "Lauryn Hill" ,Label = "label1", Type = "CD", Stock = 15 }
            );
        }
    }
}