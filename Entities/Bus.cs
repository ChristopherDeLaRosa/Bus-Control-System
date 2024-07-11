using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bus
    {
        public int BusID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Plate { get; set; }
        public string Color { get; set; }
        public int YearProduction { get; set; }
        public bool IsAvailable { get; set; }
    }
}
