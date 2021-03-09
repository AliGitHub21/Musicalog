using System.Threading.Tasks;
using Musicalog.BLL.Interfaces;
using Musicalog.BLL.Persistence.Context;

namespace Musicalog.BLL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MusicDbContext _repoContext; 
        private IAlbumRepository _albumRepository; 

        public UnitOfWork(MusicDbContext repositoryContext) 
        { 
            _repoContext = repositoryContext; 
        }
        
        public IAlbumRepository Album 
        { 
            get 
            { 
                if (_albumRepository == null) 
                { 
                    _albumRepository = new AlbumRepository(_repoContext); 
                } 
                return _albumRepository; 
            } 
        }

        public async Task SaveAsync()
        {
            await _repoContext.SaveChangesAsync();
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
        
        public void Dispose()
        {
            _repoContext.Dispose();
        }
    }
}