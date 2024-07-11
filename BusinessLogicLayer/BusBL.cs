using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BusBL
    {
        private BusDAL busDAL = new BusDAL();

        public void AddBus(Bus bus)
        {
            busDAL.InsertBus(bus);
        }

        public List<Bus> ReadBuses()
        {
            return busDAL.ReadBuses();
        }

        public void UpdateBus(Bus bus)
        {
            busDAL.UpdateBus(bus);
        }

        public void DeleteBus(int busID)
        {
            busDAL.DeleteBus(busID);
        }
    }
}
