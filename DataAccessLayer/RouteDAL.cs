using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RouteDAL
    {
        private string _connectionString = "Data Source = LAPTOP-LGPSKH9S\\SQLEXPRESS; Initial Catalog = BusControlSystem; Integrated Security = True; TrustServerCertificate = True; Trusted_Connection = True";

        public void InsertRoute(Route route)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SP_InsertRoute", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RouteName", route.RouteName);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Route> ReadRoutes()
        {

            List<Route> routes = new List<Route>();

            using(SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ReadRoutes", conn);
                cmd.CommandType= CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Route route = new Route
                    {
                        RouteID = (int)reader["RouteID"],
                        RouteName = reader["RouteName"].ToString(),
                        IsAvailable = (bool)reader["IsAvailable"]
                    };
                    routes.Add(route);
                }
            }
            return routes;
        }

        public void UpdateRoute(Route route)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("sp_UpdateRoute", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RouteID", route.RouteID);
                    cmd.Parameters.AddWithValue("@RouteName", route.RouteName);
                    cmd.Parameters.AddWithValue("@IsAvailable", route.IsAvailable);
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteRoute(int routeID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RouteID", routeID);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
