using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.TableDataGateway
{
    public class ClasroomDataGateway : TableDataGateway<ClasroomDataGateway>
    {
        public new static DataTable Find(SqlConnection connection)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Classroom_DDM;", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }
        public static DataTable Capacity(SqlConnection connection)
        {
            var table = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT DISTINCT capacity FROM Classroom_DDM;", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
                return table;
            }
        }
        public static DataTable FindByID(SqlConnection connection,int classroom_id)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("select first_name, last_name from Lector_DDM where lector_id = @idL; ", connection))
            {
                command.Parameters.AddWithValue("@idL", classroom_id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;

        }
    }
}
