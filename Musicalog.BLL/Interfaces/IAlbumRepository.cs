using System.Collections.Generic;
using System.Threading.Tasks;
using Musicalog.DAL.Entities;

namespace Musicalog.BLL.Repositories
{
    public interface IAlbumRepository
    {
        Task<IEnumerable<Album>> GetAllAlbumsAsync();
        Task<Album> GetAlbumByIdAsync(int albumId);
        Task<Album> AddAlbumAsync(Album album);
        Task<Album> RemoveAlbumAsync(int albumId);
        void UpdateAlbum(Album album);
    }
}