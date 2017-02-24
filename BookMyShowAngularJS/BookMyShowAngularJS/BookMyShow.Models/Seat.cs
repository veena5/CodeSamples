using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
   public class Seat
    {
       public string Id { get; set; }

       public BookMyShow.Models.Enums.SeatStatus Status { get; set; }

       public string ImageUrl { get; set; }
    }
}
