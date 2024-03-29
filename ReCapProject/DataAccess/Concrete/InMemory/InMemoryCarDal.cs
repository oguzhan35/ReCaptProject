﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=300.000,ModelYear=2012,Description="Audi"},
            new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=3000.000,ModelYear=2021,Description="Bently"},
            new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=100.000,ModelYear=2000,Description="BMW"},
            new Car{Id=4,BrandId=4,ColorId=4,DailyPrice=2500.000,ModelYear=2020,Description="Mercedes"}
            
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(x=>x.Id==car.Id);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars.ToList();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(x=>x.Id==id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
