using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Quill_Lite_App.Models
{
    public class Quill
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Material { get; set; }
        public string? Ratings { get; set; }
        public string? SizeFit { get; set; }
        public string? Color { get; set; }
        public decimal Price { get; set; }

        public string? ImagePath { get; set; }  // Path to the uploaded image

        [NotMapped]
        public IFormFile? ImageFile { get; set; }  // For file upload

    }
}
