using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Musicalog.BLL.Interfaces;
using Musicalog.DAL.Entities;
using Musicalog.Presentation.ViewModels;

namespace Musicalog.Presentation.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;
        
        public AlbumService(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<AlbumVm>> GetAllAlbumsAsync()
        {
            var result = await _repository.Album.GetAllAlbumsAsync();
            return _mapper.Map<IEnumerable<AlbumVm>>(result);
        }

        public async Task<AlbumVm> GetAlbumByIdAsync(int albumId)
        {
            var result = await _repository.Album.GetAlbumByIdAsync(albumId); 
            var foundAlbum = _mapper.Map<AlbumVm>(result);
            return foundAlbum;
        }

        public async Task<AlbumVm> AddAlbumAsync(AlbumForAddVm albumToAdd)
        {
            var albumEntity = _mapper.Map<Album>(albumToAdd);
            var addedAlbum = await _repository.Album.AddAlbumAsync(albumEntity); 
            await _repository.SaveAsync();
            var createdAlbum = _mapper.Map<AlbumVm>(addedAlbum);
            return createdAlbum;
        }

        public async Task<AlbumVm> RemoveAlbumAsync(int albumId)
        {
            var albumEntity = await _repository.Album.GetAlbumByIdAsync(albumId);
            if (albumEntity == null)
            {
                return null;
            }
            await _repository.Album.RemoveAlbumAsync(albumEntity.Id); 
            await _repository.SaveAsync();
            var removedAlbum = _mapper.Map<AlbumVm>(albumEntity);
            return removedAlbum;
        }

        public void UpdateAlbum(AlbumForUpdateVm albumToUpdate)
        {
            var albumEntity = _mapper.Map<Album>(albumToUpdate);
            _repository.Album.UpdateAlbum(albumEntity); 
            _repository.Save();
        }
    }
}