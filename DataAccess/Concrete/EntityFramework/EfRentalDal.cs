using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext> , IRentalDal
    {
        public List<RentableCarDto> GetRentableCars()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars
                             join rent in context.Rentals
                             on car.CarId equals  rent.CarId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             select new RentableCarDto
                             {
                                 CarId = rent.CarId,
                                 BrandName = brand.BrandName,
                                 CarName = car.CarName,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description,
                                 RentDate = rent.RentDate,
                                 ReturnDate=rent.ReturnDate

                             };

                return result.ToList();

            }
        }
    }
}
