using System.Collections.Generic;
using System.Threading.Tasks;
using Musicalog.BLL.Interfaces;
using Musicalog.BLL.Persistence.Context;
using Musicalog.DAL.Entities;

namespace Musicalog.BLL.Repositories
{
    public class AlbumRepository : RepositoryBase<Album>, IAlbumRepository
    {
        public AlbumRepository(MusicDbContext repositoryContext) 
                : base(repositoryContext) 
            { 
            }

            /// <summary>
            /// Returns list of all albums from DB(Async)
            /// </summary>
            /// <returns></returns>
            public async Task<IEnumerable<Album>> GetAllAlbumsAsync()
            {
                return await GetAllAsync();
            }

            /// <summary>
            /// Return specific Album with matching 'albumId' if exists from DB(Async)
            /// </summary>
            /// <param name="albumId"></param>
            /// <returns></returns>
            public async Task<Album> GetAlbumByIdAsync(int albumId)
            {
                return await GetByIdAsync(albumId);
                   
            }

            /// <summary>
            /// Add a new record of album to DB(Async)
            /// </summary>
            /// <param name="album"></param>
            public async Task<Album> AddAlbumAsync(Album album)
            {
                return await AddAsync(album);
            }

            /// <summary>
            /// Remove an existing album record from DB(Async)
            /// </summary>
            /// <param name="albumId"></param>
            public async Task<Album> RemoveAlbumAsync(int albumId)
            {
                return await RemoveAsync(albumId);
            }
            
            /// <summary>
            /// Update an existing album record in DB
            /// </summary>
            /// <param name="album"></param>
            public void UpdateAlbum(Album album)
            {
                Update(album);
            }
    }
}