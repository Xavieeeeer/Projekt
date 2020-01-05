using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using DTO.DTOs;
namespace DataLayer.TableDataGateway
{
    public class StudentDataGateway : TableDataGateway<StudentDataGateway>
    {
        public new static DataTable Find(SqlConnection connection)
        {
            var dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Student_DDM;", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }
        public static DataTable AttendenceStudent(SqlConnection connection)
        {
            var table = new DataTable();
            using (SqlCommand command = new SqlCommand("SELECT s.student_id,ISNULL((SELECT COUNT(DISTINCT a.lecture_lecture_id)FROM Attendence_DDM a " +
                "WHERE s.student_id = a.student_student_id) /NULLIF((SELECT CAST(COUNT(l.course_course_id) as FLOAT) FROM Course_DDM c " +
                "JOIN Lecture_DDM l ON l.course_course_id = c.course_id JOIN Study_DDM ss ON ss.course_course_id = c.course_id AND s.student_id = ss.student_student_id" +
                "), 0),0) *100 FROM Student_DDM s; ", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
                return table;
            }
        }
        // Finding students by giving parametrs 
        public static Collection<Student> SelectBy(SqlConnection connection,int? studentID=null,string first_name=null,string last_name=null,int? phone_number=null,string email=null,DateTime? birth_date = null)
        {
            Collection<Student> students = null;
            string sqlSelect = "SELECT s.student_id,s.first_name,s.last_name,s.phone_number,s.email,s.birth_date FROM Student_DDM s ";
            bool isFirst = true;
            if (studentID != null)
            {
                isFirst = false;
                sqlSelect = sqlSelect + "WHERE s.student_id = @studentID";
            }
            if (first_name != null)
            {
                sqlSelect += isFirst ? "WHERE s.first_name = @first_name" : "AND  s.first_name = @first_name";
                isFirst = false;
            }
            if(last_name !=null)
            {
                sqlSelect += isFirst ? "WHERE s.last_name = @last_name" : "AND  s.last_name = @last_name";
                isFirst = false;
            }
            if(phone_number != null)
            {
                sqlSelect += isFirst ? "WHERE s.phone_number = @phone_number" : "AND  s.phone_number = @phone_number";
                isFirst = false;
            }
            if (email != null)
            {
                sqlSelect += isFirst ? "WHERE s.email = @email" : "AND  s.email = @email";
                isFirst = false;
            }
            if (birth_date != null)
            {
                sqlSelect += isFirst ? "WHERE s.birth_date = @birth_date" : "AND  s.birth_date = @birth_date";
                isFirst = false;
            }
            using(var command = new SqlCommand(sqlSelect, connection))
            {
                if (studentID != null)
                    command.Parameters.AddWithValue("@studentID", studentID);
                if (first_name != null)
                    command.Parameters.AddWithValue("@first_name", first_name);
                if (last_name != null)
                    command.Parameters.AddWithValue("@last_name", last_name);
                if (phone_number != null)
                    command.Parameters.AddWithValue("@phone_number", phone_number);
                if (email != null)
                    command.Parameters.AddWithValue("@email", email);
                if (birth_date != null)
                    command.Parameters.AddWithValue("@birth_date", birth_date);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                     students = Read(reader);
                   
                }
            }
            return null;

        }
        private static Collection<Student> Read(SqlDataReader reader)
        {
            var students = new Collection<Student>();
            while (reader.Read())
            {
                Student student = new Student();
                int i= -1;
                student.studentID = reader.GetInt32(++i);
                student.firstName = reader.GetString(++i);
                student.lastnName = reader.GetString(++i);
                student.phoneNumber = reader.GetInt32(++i);
                student.email = reader.GetString(++i);
                student.birhtDate = reader.GetDateTime(++i);

                students.Add(student);
            }
            return students;
        }
    }
}
