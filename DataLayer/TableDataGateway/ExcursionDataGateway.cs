using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer.TableDataGateway
{
    public class ExcursionDataGateway : TableDataGateway<ExcursionDataGateway>
    {
        public new static DataTable Find(SqlConnection connection)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Excursion_DDM;", connection))
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
