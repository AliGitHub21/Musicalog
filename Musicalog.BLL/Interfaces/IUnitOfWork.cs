using System;
using System.Threading.Tasks;

namespace Musicalog.BLL.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IAlbumRepository Album { get; }
        Task SaveAsync();
        void Save();
    }
}