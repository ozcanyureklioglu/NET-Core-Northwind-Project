using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category:IEntity
    {

        public int category_id { get; set; }

        public string  category_name { get; set; }


        public Category()
        {
        }
    }
}

