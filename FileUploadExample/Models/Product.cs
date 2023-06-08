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
}
