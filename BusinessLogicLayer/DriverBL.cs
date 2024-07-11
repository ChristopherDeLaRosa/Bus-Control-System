using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DriverBL
    {
        private DriverDAL driverDAL = new DriverDAL();

        public void AddDriver(Driver driver)
        {     
            driverDAL.InsertDriver(driver);
        }

        public List<Driver> ReadDrivers()
        {
            return driverDAL.ReadDrivers();
        }

        public Driver GetDriver(int driverID)
        {
            return driverDAL.GetDriver(driverID);
        }

        public void UpdateDriver(Driver driver)
        {
            driverDAL.UpdateDriver(driver);
        }

        public void DeleteDriver(int driverID)
        {
            driverDAL.DeleteDriver(driverID);
        }
    }
}
