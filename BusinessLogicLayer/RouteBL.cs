using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class RouteBL
    {
        private RouteDAL  routeDAL = new RouteDAL();

        public void AddRoute(Route route)
        {
            routeDAL.InsertRoute(route);
        }
        public List<Route> ReadRoutes()
        {
            return routeDAL.ReadRoutes();
        }

        public void UpdateRoute(Route route)
        {
            routeDAL.UpdateRoute(route);
        }

        public void DeleteRoute(int routeID)
        {
            routeDAL.DeleteRoute(routeID);
        }
    }
}
