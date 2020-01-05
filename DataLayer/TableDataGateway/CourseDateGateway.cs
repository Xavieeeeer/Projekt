using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO.DTOs;
using System.Collections.ObjectModel;

namespace DataLayer.TableDataGateway
{
    public class CourseDataGateway : TableDataGateway<CourseDataGateway>
    {
        public new static DataTable Find(SqlConnection connection)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Course_DDM;", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }
        public static DataTable RegistredCourses(SqlConnection connection, int? student_id = null)
        {
            var dataTable = new DataTable();
            String sql = "SELECT c.course_id,c.course_name,c.capacity,c.difficulty,cc.floor_number,cc.room_number,Count(e.excursion_id)AS totalExcursion,SUM(e.cost)AS totalCost,l.first_name,l.last_name,l.email " +
                "FROM Course_DDM c " +
                "JOIN Classroom_DDM cc ON cc.classroom_id = c.Classroom_classroom_id " +
                "LEFT JOIN Excursion_DDM e ON e.course_course_id = c.course_id " +
                "JOIN Work_DDM w ON w.course_course_id = c.course_id " +
                "JOIN Lector_DDM l ON l.lector_id = w.lector_lector_id " +
                "JOIN Study_DDM ss ON ss.course_course_id = c.course_id " +
                "JOIN Student_DDM  s ON s.student_id = ss.student_student_id " +
                "WHERE s.student_id = @student_id " +
                "GROUP BY c.course_id,c.course_name,c.capacity,c.difficulty,cc.floor_number,cc.room_number,l.first_name,l.last_name,l.email ";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@student", (object)student_id ?? DBNull.Value);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }
        public new static DataTable FindType(SqlConnection connection)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT DISTINCT c.course_name FROM Course_DDM c;", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }
        public new static DataTable FindDifficulty(SqlConnection connection)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT DISTINCT c.difficulty  FROM Course_DDM c;", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
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
