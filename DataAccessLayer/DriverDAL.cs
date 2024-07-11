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
    public class DriverDAL
    {
        private string _connectionString = "Data Source = LAPTOP-LGPSKH9S\\SQLEXPRESS; Initial Catalog = BusControlSystem; Integrated Security = True; TrustServerCertificate = True; Trusted_Connection = True";

        public void InsertDriver(Driver driver)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SP_InsertDriver", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", driver.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", driver.LastName);
                    cmd.Parameters.AddWithValue("@BirthDate", driver.BirthDate);
                    cmd.Parameters.AddWithValue("@IDNumber", driver.IDNumber);
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Driver> ReadDrivers()
        {
            List<Driver> drivers = new List<Driver>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_ReadDrivers", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Driver driver = new Driver
                    {
                        DriverID = (int)reader["DriverID"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        BirthDate = (DateTime)reader["BirthDate"],
                        IDNumber = (string)reader["IDNumber"],
                        IsAvailable = (bool)reader["IsAvailable"]
                    };
                    drivers.Add(driver);
                }
            }

            return drivers;
        }

        public Driver GetDriver(int driverId)
        {

            try
            {
                Driver driver = null;
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetDriver", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DriverID", driverId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            driver = new Driver
                            {
                                DriverID = (int)reader["DriverID"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                BirthDate = (DateTime)reader["BirthDate"],
                                IDNumber = (string)reader["IDNumber"],
                                IsAvailable = (bool)reader["IsAvailable"]
                            };
                        }
                    }

                    connection.Close();

                }
                return driver;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateDriver(Driver driver)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateDriver", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FirstName", driver.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", driver.LastName);
                    cmd.Parameters.AddWithValue("@BirthDate", driver.BirthDate);
                    cmd.Parameters.AddWithValue("@IDNumber", driver.IDNumber);
                    cmd.Parameters.AddWithValue("@IsAvailable", driver.IsAvailable);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteDriver(int driverId)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteDriver", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@DriverID", driverId);

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
