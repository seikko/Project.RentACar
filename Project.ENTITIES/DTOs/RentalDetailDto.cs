using Project.CORE.Entities.DTOClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.DTOs
{
   public class RentalDetailDto:IDto
    {
        public int ID { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }
    }
}
