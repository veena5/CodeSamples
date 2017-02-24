using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class BookingInfo
    {
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public DateTime ShowDate { get; set; }
        public string ShowTime { get; set; }
        public string SeatsBooked { get; set; }
    }
}
