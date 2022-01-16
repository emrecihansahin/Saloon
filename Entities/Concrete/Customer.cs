using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string CustomerFullName { get; set; }
        public int CityId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
