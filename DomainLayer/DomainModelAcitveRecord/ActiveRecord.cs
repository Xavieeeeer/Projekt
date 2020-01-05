using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DomainLayer.DomainModelAcitveRecord
{
    public abstract class ActiveRecord<T> : IdentityMap<T> where T : IDentity
    {
        public static T Find(int id, SqlConnection connection) { throw new NotImplementedException(); }

        public static T MapResultToObject(SqlDataReader reader) { throw new NotImplementedException(); }

        public static void Update(T updatedT, SqlConnection connection) { throw new NotImplementedException(); }
    }
}
