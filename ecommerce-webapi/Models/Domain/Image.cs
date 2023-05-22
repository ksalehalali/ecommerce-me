using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce_webapi.Models.Domain
{
    public class Image
    {
        public Guid Id { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string FileExtention { get; set; }
        public string FilePath { get; set; }
        public long FileSizeInBytes { get; set; }

    }
}
