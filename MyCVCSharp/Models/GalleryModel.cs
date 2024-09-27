using System.ComponentModel.DataAnnotations;

namespace MyCVCSharp.Models
{
    public class GalleryModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Image Title")]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }

        [Display(Name = "Uploaded On")]
        public DateTime UploadedOn { get; set; }
    }
}
