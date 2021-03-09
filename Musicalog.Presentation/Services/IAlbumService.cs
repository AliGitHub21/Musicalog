using System.Collections.Generic;
using System.Threading.Tasks;
using Musicalog.DAL.Entities;
using Musicalog.Presentation.ViewModels;

namespace Musicalog.Presentation.Services
{
    public interface IAlbumService
    {
        Task<IEnumerable<AlbumVm>> GetAllAlbumsAsync();
        Task<AlbumVm> GetAlbumByIdAsync(int albumId);
        Task<AlbumVm> AddAlbumAsync(AlbumForAddVm albumToAdd);
        Task<AlbumVm> RemoveAlbumAsync(int albumId);
        void UpdateAlbum(AlbumForUpdateVm albumToUpdate);
    }
}