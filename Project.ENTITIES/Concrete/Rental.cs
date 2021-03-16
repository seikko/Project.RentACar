using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Concrete
{
   public class Rental:IEntity
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public int CustomerID { get; set; }
        public DateTime? RentDate { get; set; }

    }
}
