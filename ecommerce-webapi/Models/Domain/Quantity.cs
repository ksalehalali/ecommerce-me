using ecommerce_webapi.Models.DTO;
using System.Collections.Generic;

namespace ecommerce_webapi.Models.Domain
{
    public class Quantity
    {
        public Guid Id { get; set; }
        public int ItemsCount { get; set; }
        public Guid SizeId { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public Guid ColorId { get; set; }

        
        public List<ImageUrlDto> ImagesUrl { get; set; }
    }
}
