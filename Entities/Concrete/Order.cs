using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int order_id { get; set; }

        public string costumer_id { get; set; }

        public int employee_id { get; set; }

        public DateTime order_date { get; set; }

        public string ship_city { get; set; }
    }
}

