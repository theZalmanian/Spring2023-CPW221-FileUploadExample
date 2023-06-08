using System.ComponentModel.DataAnnotations;

namespace FileUploadExample.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductTitle { get; set; }

        public string ProductImageUrl { get; set; }
    }

    public class CreateProductViewModel
    {
        public string Title { get; set; }

        public IFormFile Image { get; set; }
    }
}
