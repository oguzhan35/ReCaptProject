using System;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
namespace ConsoleUl
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Id = 5,
                ColorId = 3,
                BrandId = 2,
                DailyPrice = 340.000,
                Description = "BMW 320d",
                ModelYear=2009


            };


            

            Console.ReadLine();
        }
    }
}
