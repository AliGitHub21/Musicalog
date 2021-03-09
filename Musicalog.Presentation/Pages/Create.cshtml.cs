
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Musicalog.Presentation.Services;
using Musicalog.Presentation.ViewModels;

namespace Musicalog.Presentation.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IAlbumService _albumService;

        public CreateModel(IAlbumService albumService)
        {
            _albumService = albumService;
        }
        
        [BindProperty]
        public AlbumForAddVm Album { get; set; }

        public void OnGet()
        {
            this.Album = new AlbumForAddVm();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var album = await _albumService.AddAlbumAsync(this.Album);
            if(album == null)
                return RedirectToPage("./Error");
            return RedirectToPage("./Index");
        }
    }
}