﻿

using ecommerce_webapi.Models.DTO;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce_webapi.Models.Domain
{
    public class Quantity
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public int ItemsCount { get; set; }
        public Guid SizeId { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public Guid ColorId { get; set; }
        public DateTime AddedDate { get; set; }
        public Guid? User { get; set; }

        
    }
}
