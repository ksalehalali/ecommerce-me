using ecommerce_webapi.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce_webapi.Models.DTO
{
    public class QuantityDto
    {
        public Guid ProductId { get; set; }
        public int ItemsCount { get; set; }
        public Guid SizeId { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public Guid ColorId { get; set; }
        public List<ImagesUrls> ImagesUrls { get; set; }
    }
}
