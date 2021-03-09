using System;
using System.ComponentModel.DataAnnotations;

namespace Musicalog.DAL.Entities
{
    public partial class Album
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public int Stock { get; set; }
    }
}
