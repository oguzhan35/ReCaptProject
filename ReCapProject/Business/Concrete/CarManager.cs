using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Business.Concrete
{
    
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandDal _brandDal;

        public CarManager(ICarDal carDal,IBrandDal brandDal)
        {
            _carDal = carDal;
            _brandDal = brandDal;
        }

        public void Add(Car car)
        {

            

            if (car.DailyPrice>0 )
            {
                _carDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
