using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, CarName="GTR-35", ColorId=1, DailyPrice=650000, Description="50. Yıl Özel", ModelYear="2020"}
            };
        }

        public void Add(Car car)
        {
            Car carToAdd = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Add(carToAdd);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Add(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCarBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCarColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCarId(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToAdd = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToAdd.CarName = car.CarName;
            carToAdd.ColorId = car.ColorId;
            carToAdd.DailyPrice = car.DailyPrice;
            carToAdd.Description = car.Description;
            
        }
    }
}
