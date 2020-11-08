using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class Koncerti
    {
        public int concertId { get; set; }
        public string concert_Name { get; set; }
        public string venue_Name { get; set; }
        public int max_Seats { get; set; }
        public string genre { get; set; }
        public string date_Concert { get; set; }
    }
}
