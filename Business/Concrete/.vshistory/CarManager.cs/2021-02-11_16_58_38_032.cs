﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Add(car);
            }
            else if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Günlük fiyat 0'dan büyük olmalıdır");
            }
            else if (car.Description.Length <= 2)
            {
                Console.WriteLine("Açıklama 2 harften fazla olmalıdır");

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

        public List<Car> GetCarsByBrandId(int id)
        {
            // return _productDal.GetAll(p=>p.CategoryId==id);
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p=>p.ColorId==id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
