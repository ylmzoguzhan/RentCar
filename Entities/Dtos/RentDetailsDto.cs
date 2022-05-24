using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class RentDetailsDto:IDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Model { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal Price { get; set; }
    }
}
