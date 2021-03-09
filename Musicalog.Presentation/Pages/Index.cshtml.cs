using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Musicalog.Presentation.Services;
using Musicalog.Presentation.ViewModels;

namespace Musicalog.Presentation.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IAlbumService _albumService;

        [BindProperty]
        public IEnumerable<AlbumVm> AllAlbumsAsync { get; set; } 

        public IndexModel(IAlbumService albumService, IMapper mapper)
        {
            _albumService = albumService;
        }

        public async Task OnGet()  
        {  
            this.AllAlbumsAsync = await _albumService.GetAllAlbumsAsync();
        }  
    }
}
