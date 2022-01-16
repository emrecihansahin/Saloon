using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order: Core.IEntity
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public double ServicePrice { get; set; }
        public string OrderType { get; set; }

    }
}
