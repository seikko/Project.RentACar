using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Concrete
{
   public class CarImage:IEntity
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
