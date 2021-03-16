using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Concrete
{
   public class Customer:IEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string CompanyName { get; set; }

    }
}
