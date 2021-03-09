using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Musicalog.Presentation.Services;
using Musicalog.Presentation.ViewModels;

namespace Musicalog.Presentation.Pages
{
    public class EditModel : PageModel
    {
        private readonly IAlbumService _albumService;

        public EditModel(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [BindProperty]
        public AlbumForUpdateVm AlbumToUpdate { get; set; }
        
        [BindProperty]
        public AlbumVm Album { get; set; }

        public string Title { get; set; }
        public string SelectedType { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            var model = await _albumService.GetAlbumByIdAsync(id);
            if (model == null)
                return RedirectToPage("./Index");

            this.Title = model.Name;
            this.Album = new AlbumVm{
                Id = model.Id,
                Name = model.Name,
                Artist = model.Artist,
                Label = model.Label,
                Type = this.SelectedType =  model.Type,
                Stock = model.Stock
            };
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            this.AlbumToUpdate = new AlbumForUpdateVm
            {
                Id = this.Album.Id,
                Name = this.Album.Name,
                Artist = this.Album.Artist,
                Label = this.Album.Label,
                Type = this.Album.Type,
                Stock = this.Album.Stock
            };
            _albumService.UpdateAlbum(this.AlbumToUpdate);

            return RedirectToPage("./Index");
        }
    }
}