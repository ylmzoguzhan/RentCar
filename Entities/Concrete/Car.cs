using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Capacity { get; set; }
        public int GearId { get; set; }
        public decimal DailyPrice { get; set; }
        public bool Rent { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}
