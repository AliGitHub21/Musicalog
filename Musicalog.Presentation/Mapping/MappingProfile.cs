using AutoMapper;
using Musicalog.DAL.Entities;
using Musicalog.Presentation.ViewModels;

namespace Musicalog.Presentation.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Mapping from Source -> destination
            CreateMap<Album, AlbumVm>();
            CreateMap<AlbumForAddVm, Album>();
            CreateMap<AlbumForUpdateVm, Album>();
        }
    }
}