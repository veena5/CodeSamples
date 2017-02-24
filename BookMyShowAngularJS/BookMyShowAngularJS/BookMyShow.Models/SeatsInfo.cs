using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class SeatsInfo
    {
        public int NoOfPremiumRows { get; set; }
        public int NoOfStandardRows { get; set; }
        public List<Seat> PremiumSeats { get; set; }
        public List<Seat> StandardSeats { get; set; }
    }
}
