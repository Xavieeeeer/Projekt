using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DomainLayer;


namespace DomainLayer.DomainModelAcitveRecord
{
    public class CourseActiveRecord : ActiveRecord<CourseActiveRecord>, DomainLayer.IDentity
    {
        public int ID { get; set; }
        public String course_name { get; set; }
        public String difficulty { get; set; }
        public int capacity { get; set; }
        public int classroom_id { get; set; }

        public static void AddCourse(string c_name, char c_level, int c_capacity, int c_class, SqlConnection connection)
        {

            string sql = "exec addCourse " + c_name + ", @level, " + ", @capacity, @class";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@level", c_level);
                command.Parameters.AddWithValue("@capacity", c_capacity);
                command.Parameters.AddWithValue("@class", c_class);
                command.ExecuteNonQuery();
            }
        }
        public static bool CourseIsValid(string c_name, char c_level, SqlConnection connection)
        {
            string sql = "select * from Course_DDM where course_name = '" + c_name + "' and difficulty = @level";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@level", c_level);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return false;
                }
            }
            return true;
        }
        public static bool ClassroomIsValid(int c_capacity, int c_class, SqlConnection connection)
        {

            string sql = "select capacity from Classroom_DDM where room_number= @number";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@number", c_class);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        if (reader.GetInt32(0) < c_capacity)
                            return false;
                }
            }
            return true;
        }
    }
}
