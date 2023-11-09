using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_plac
{
     public  class Podatoci
    {
        public String id { set; get; }
        public DateTime time { set; get; }
        public Podatoci(String id, DateTime time)
        {
            this.id = id;
            this.time = time;
        }
    }
}
