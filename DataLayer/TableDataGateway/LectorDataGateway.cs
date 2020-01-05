using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataLayer.TableDataGateway
{
    public class LectorDataGateway : TableDataGateway<LectorDataGateway>
    {
        public new static DataTable FindByID(SqlConnection connection, int lector_id)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT l.first_name,l.last_name from Lector_DDM l  WHERE l.lector_id = @lector_id;", connection))
            {
                command.Parameters.AddWithValue("@lector_id", lector_id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }
        public new static DataTable Find(SqlConnection connection)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT * from Lector_DDM;", connection))
            {
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }
    }
}
