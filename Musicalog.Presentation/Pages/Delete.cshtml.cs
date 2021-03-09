using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Musicalog.Presentation.Services;

namespace Musicalog.Presentation.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly IAlbumService _albumService;

        public DeleteModel(IAlbumService albumService, IMapper mapper)
        {
            _albumService = albumService;
        }

        [BindProperty]
        public int Id { get; set; }
        public string Title { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            var model = await _albumService.GetAlbumByIdAsync(id);
            if (model == null)
                return RedirectToPage("./Index");

            this.Id = model.Id;
            this.Title = model.Name;
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            var removedCustomer = await _albumService.RemoveAlbumAsync(this.Id);
            if (removedCustomer == null)
                return RedirectToPage("./Error");
            return RedirectToPage("./Index");
        }
    }
}