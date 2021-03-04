using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{BrandId=1,Id=1,ColorId=1,DailyPrice=100,ModelYear=1990,Descriptions="2nd Hand"},
                new Car{BrandId=2,Id=2,ColorId=5,DailyPrice=500,ModelYear=2000,Descriptions="2nd Hand"}
            };
        }
        public void Add(Car entity)
        {
            _car.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDeleted = _car.SingleOrDefault(c => c.Id == entity.Id);
            _car.Remove(entity);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car carToUpdated = _car.SingleOrDefault(c => c.Id == entity.Id);
            carToUpdated.BrandId = entity.BrandId;
            carToUpdated.Id = entity.Id;
            carToUpdated.ColorId = entity.ColorId;
            carToUpdated.DailyPrice = entity.DailyPrice;
            carToUpdated.Descriptions = entity.Descriptions;
            carToUpdated.ModelYear = entity.ModelYear;
        }
    }
}
