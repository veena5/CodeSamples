using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string TheaterName { get; set; }
        public DateTime ShowDate { get; set; }
        public string ShowTime { get; set; }
        public string SeatsBooked { get; set; }
    }
}
