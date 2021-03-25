using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BusPlan2_DAL.Handlers
{
    public class BusHandler
    {
        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public bool UpdateStatus(int busNumber, int status) 
        {
            var connection = Connection.GetConnection();
            try
            {
                using (connection)
                {
                    string query = "UPDATE Bus SET Status = @Status WHERE BusNumber = @BusNumber";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@BusNumber", busNumber);
                    }
                }
                return true;
            }
            catch { connection.Close(); return false; }
        }
    }
    }
}
