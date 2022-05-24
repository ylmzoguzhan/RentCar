using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Coord:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}
