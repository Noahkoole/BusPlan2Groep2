using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using BusPlan2_DAL.DTOs;

namespace BusPlan2_DAL.Handlers
{
    public class ParkingSpaceHandler
    {
        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Update(ParkingSpaceDTO ParkingSpace)
        {
            var connection = Connection.GetConnection();

            using (connection)
            {
                string query = "UPDATE ParkingSpace SET BusID = @BusID, Type = @Type, Occupied = @Occupied WHERE Number = @Number";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BusID", ParkingSpace.BusID);
                    command.Parameters.AddWithValue("@Type", ParkingSpace.Type);
                    command.Parameters.AddWithValue("@Occupied", ParkingSpace.Occupied);
                    command.Parameters.AddWithValue("@Number", ParkingSpace.Number);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete()
        {

        }
    }
}
