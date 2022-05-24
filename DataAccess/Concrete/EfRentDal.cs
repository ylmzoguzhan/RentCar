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
    public class EfRentDal : EfEntityRepositoryBase<Rent, RentCarContext>, IRentDal
    {
        public List<RentDetailsDto> GetRentDetailsByUserId(int id)
        {
            using (var context = new RentCarContext())
            {
                var result = from rent in context.Rents

                             join user in context.Users
                             on rent.UserId equals user.Id

                             join car in context.Cars
                             on rent.CarId equals car.Id


                             where (rent.UserId == id)
                             select new RentDetailsDto
                             {
                                 Id = rent.Id,
                                 UserName = user.FirstName,
                                 Model = car.Model,
                                 Price = car.DailyPrice,
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate,
                             };
                return result.ToList();
            }
        }

        public List<RentDetailsDto> GetRentDetails()
        {
            using (var context = new RentCarContext())
            {
                var result = from rent in context.Rents

                             join user in context.Users
                             on rent.UserId equals user.Id

                             join car in context.Cars
                             on rent.CarId equals car.Id

                             

                             select new RentDetailsDto
                             {
                              Id = rent.Id,
                              UserName = user.FirstName,
                              Model = car.Model,
                              Price = car.DailyPrice,
                              RentDate = rent.RentDate,
                              ReturnDate = rent.ReturnDate,
                             };
                return result.ToList();
            }
        }
    }
}
