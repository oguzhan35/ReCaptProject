﻿using Entities.Abstract;
using System;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        // Id, BrandId, ColorId, ModelYear, DailyPrice, Description

        public int Id { get; set; }

        public int BrandId { get; set; }

        public int ColorId { get; set; }

        public int ModelYear { get; set; }

        public double DailyPrice { get; set; }

        public string Description { get; set; }

    }
}
