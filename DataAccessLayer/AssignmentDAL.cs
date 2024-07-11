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
    public class AssignmentDAL
    {
        private string _connectionString = "Data Source = LAPTOP-LGPSKH9S\\SQLEXPRESS; Initial Catalog = BusControlSystem; Integrated Security = True; TrustServerCertificate = True; Trusted_Connection = True";

        public void AssignDriverToBusAndRoute(Assignment assignment)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_AssignDriverToBusAndRoute", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DriverID", assignment.DriverID);
                    cmd.Parameters.AddWithValue("@BusID", assignment.BusID);
                    cmd.Parameters.AddWithValue("@RouteID", assignment.RouteID);
                    cmd.Parameters.AddWithValue("@AssignmentDate", assignment.AssignmentDate);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ReleaseDriverBusAndRoute(int assignmentId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ReleaseDriverBusAndRoute", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentId);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateAssginment(Assignment assignment)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateAssignment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@DriverID", assignment.DriverID);
                    cmd.Parameters.AddWithValue("@BusID", assignment.BusID);
                    cmd.Parameters.AddWithValue("@RouteID", assignment.RouteID);
                    cmd.Parameters.AddWithValue("@AssignmentDate", assignment.AssignmentDate);

                    cmd.ExecuteNonQuery();

                    conn.Close();                                   

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteAssignment(int assignmentId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteAssignment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AssignmentID", assignmentId);
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
