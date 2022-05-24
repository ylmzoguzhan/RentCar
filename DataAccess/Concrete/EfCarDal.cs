using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailsDto> GetListCarDetail()
        {
            using (var context = new RentCarContext())
            {
                var result = from car in context.Cars
                             
                             join brand in context.Brands
                             on car.BrandId equals brand.Id

                             join gear in context.Gears
                             on car.GearId equals gear.Id

                             select new CarDetailsDto
                             {  
                                 Rent = car.Rent,
                                 CarId = car.Id,
                                 Brand = brand.Name,
                                 Model = car.Model,
                                 Year = car.Year,
                                 Capacity = car.Capacity,
                                 DailyPrice = car.DailyPrice,
                                 Lat = car.Lat,
                                 Lng = car.Lng,
                                 Gear = gear.Name
                             };
                return result.ToList();
            }
        }

        public List<CarDetailsDto> GetListCarDetailByRent()
        {
            using (var context = new RentCarContext())
            {
                var result = from car in context.Cars

                             join brand in context.Brands
                             on car.BrandId equals brand.Id

                             join gear in context.Gears
                             on car.GearId equals gear.Id
                             where (car.Rent==false)
                             select new CarDetailsDto
                             {
                                 Rent = car.Rent,
                                 CarId = car.Id,
                                 Brand = brand.Name,
                                 Model = car.Model,
                                 Year = car.Year,
                                 Capacity = car.Capacity,
                                 DailyPrice = car.DailyPrice,
                                 Lat = car.Lat,
                                 Lng = car.Lng,
                                 Gear = gear.Name
                             };
                return result.ToList();
            }
        }
    }
}
