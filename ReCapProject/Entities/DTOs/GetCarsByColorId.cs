using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    class GetCarsByColorId : IDto
    {
        
        public int CarId { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
