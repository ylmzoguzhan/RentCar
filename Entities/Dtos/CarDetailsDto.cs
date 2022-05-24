using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CarDetailsDto:IDto
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Capacity { get; set; }
        public decimal DailyPrice { get; set; }
        public string Gear { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public bool Rent { get; set; }
    }
}
