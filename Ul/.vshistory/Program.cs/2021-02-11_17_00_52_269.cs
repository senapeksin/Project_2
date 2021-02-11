﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace Ul
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Car car = new Car { BrandId = 1, ColorId = 1, DailyPrice = 100, ModelYear = 2018 };
            carManager.Add(car);
            foreach (var car in carManager.Add())
            {
                Console.WriteLine(car.BrandId);
            
            }
        }
    }
}
