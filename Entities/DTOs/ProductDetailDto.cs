using System;
using Core.Entities;
namespace Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public string category_name { get; set; }

        public string product_name { get; set; }

        public short units_in_stock { get; set; }

        public int units_on_order { get; set; }

        public int unit_price { get; set; } 
    }
}

