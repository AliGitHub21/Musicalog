using System.ComponentModel.DataAnnotations;

namespace Musicalog.Presentation.ViewModels
{
    public class AlbumForAddVm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Artist { get; set; }
        [Required]
        public string Label { get; set; }
        public string Type { get; set; }
        public int Stock { get; set; }
    }
}