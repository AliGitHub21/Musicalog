using Microsoft.AspNetCore.Mvc;

namespace Musicalog.Presentation.Controllers
{
    public class AlbumsController : Controller
    {
        // GET List of Albums and serves as the index page
        public IActionResult Index()
        {
            return View();
        }
    }
}