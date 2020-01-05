using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataLayer.TableDataGateway
{
    public class LectorDataGateway : TableDataGateway<LectorDataGateway>
    {
        public new static DataTable FindByID(SqlConnection connection, int course_id)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT l.first_name,l.last_name FROM Lector_DDM l " +
                                                        "JOIN Work_DDM w on w.lector_lector_id = l.lector_id " +
                                                        "JOIN Course_DDM c ON c.course_id = w.course_course_id " +
                                                        "WHERE c.course_id = @course_id;", connection))
            {
                command.Parameters.AddWithValue("@course_id", course_id);
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
            using (SqlCommand command = new SqlCommand("SELECT last_name from Lector_DDM;", connection))
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
