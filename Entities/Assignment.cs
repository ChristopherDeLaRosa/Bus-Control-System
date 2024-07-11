using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Assignment
    {
        public int AssignmetID { get; set; }
        public int DriverID { get; set; }
        public int BusID { get; set; }
        public int RouteID { get; set; }
        public DateTime AssignmentDate { get; set; }

        //References variables
        public Driver Driver { get; set; }
        public Bus Bus { get; set; }
        public Route Route { get; set; }

    }
}
