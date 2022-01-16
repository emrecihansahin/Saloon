using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BarberShop:IEntity
    {
        public int Id { get; set; }
        public string BarberShopName { get; set; }
        public string CityName { get; set; }
    }
}
