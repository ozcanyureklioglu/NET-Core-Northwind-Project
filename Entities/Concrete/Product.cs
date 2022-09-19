using System;
using Core.Entities;

namespace Entities.Concrete
{
    
    public class Product:IEntity
    {
        public Product()
        {
        }

        public int product_id { get; set; }

        public int category_id { get; set; }

        public string product_name { get; set; }

        public short units_in_stock { get; set; }

        public int units_on_order { get; set; }

        public int unit_price { get; set; }


    }
}

