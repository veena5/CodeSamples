using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class Theater
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MoviePlaying { get; set; }
        public string ShowTimings { get; set; }
        public int NoOfPremiumRows { get; set; }
        public int NoOfStandardRows { get; set; }
        public int NoOfSeatsPerRow { get; set; }

    }
}
