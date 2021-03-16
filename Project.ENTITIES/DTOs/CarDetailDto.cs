using Project.CORE.Entities.DTOClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.DTOs
{
    public class CarDetailDto:IDto
    {
        public int ID { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }
    }
}
