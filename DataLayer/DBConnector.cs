using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataLayer
{
    public class DBConnector
    {
        private SqlConnection connection;
        private static readonly DBConnector instance = new DBConnector()
        {
            connection = new SqlConnection(new SqlConnectionStringBuilder()
            {
                DataSource = @"dbsys.cs.vsb.cz\STUDENT",
                UserID = "hec0051",
                Password = "qcMtesaPCb",
                InitialCatalog = "hec0051"
            }.ConnectionString)
        };

        private DBConnector() { }

        public static DBConnector GetInstance()
        {
            return instance;
        }

        public SqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
            }
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }



}


