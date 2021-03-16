using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Concrete
{
   public class Color:IEntity
    {
        public int ID { get; set; }
        public string ColorName { get; set; }
    }
}
