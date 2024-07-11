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
    public class BusDAL
    {
        private string _connectionString = "Data Source = LAPTOP-LGPSKH9S\\SQLEXPRESS; Initial Catalog = BusControlSystem; Integrated Security = True; TrustServerCertificate = True; Trusted_Connection = True";

        public void InsertBus(Bus bus)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SP_InsertBus", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@BusID", bus.BusID);
                    cmd.Parameters.AddWithValue("@Brand", bus.Brand);
                    cmd.Parameters.AddWithValue("@Model", bus.Model);
                    cmd.Parameters.AddWithValue("@Plate", bus.Plate);
                    cmd.Parameters.AddWithValue("@Color", bus.Color);
                    cmd.Parameters.AddWithValue("@Year", bus.YearProduction);
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Bus> ReadBuses()
        {
            List<Bus> buses = new List<Bus>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_ReadBuses", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Bus bus = new Bus
                    {
                        BusID = (int)reader["BusID"],
                        Brand = reader["Brand"].ToString(),
                        Model = reader["Model"].ToString(),
                        Plate = reader["Plate"].ToString(),
                        Color = reader["Color"].ToString(),
                        YearProduction = (int)reader["YearProduction"],
                        IsAvailable = (bool)reader["IsAvailable"]

                    };
                    buses.Add(bus);
                }
            }
            return buses;
        }

        public void UpdateBus(Bus bus)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("sp_UpdateBus", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BusID", bus.BusID);
                    cmd.Parameters.AddWithValue("@Brand", bus.Brand);
                    cmd.Parameters.AddWithValue("@Model", bus.Model);
                    cmd.Parameters.AddWithValue("@Plate", bus.Plate);
                    cmd.Parameters.AddWithValue("@Color", bus.Color);
                    cmd.Parameters.AddWithValue("@YearProduction", bus.YearProduction);
                    cmd.Parameters.AddWithValue("@IsAvailable", bus.IsAvailable);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteBus(int busID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteBus", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@BusID", busID);

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
