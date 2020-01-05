using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DomainLayer.DomainModelAcitveRecord
{
    public class StudentActiveRecord : ActiveRecord<StudentActiveRecord>, DomainLayer.IDentity
    {
        public int ID { get; set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String email { get; set; }
        public int? phone_number { get; set; }
        public DateTime birth_date { get; set; }


        public new static StudentActiveRecord Find(int id, SqlConnection connection)
        {
            StudentActiveRecord student = Get(id);
            if (student == default(StudentActiveRecord))
            {
                string sql = "SELECT * FROM Student WHERE student_id = @student_id;";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("student_id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            student = MapResultToObject(reader);
                        }
                    }
                }
                Add(student);
            }
            return student;
        }
        public static StudentActiveRecord MapResultsetToObject(SqlDataReader reader)
        {
            StudentActiveRecord student = new StudentActiveRecord();
            student.ID = reader.GetInt32(0);
            student.first_name = reader.GetString(1);
            student.last_name = reader.GetString(2);
            student.email = reader.GetString(3);
            student.phone_number = reader.GetValue(4) == DBNull.Value ? null : (int?)reader.GetValue(4);
            student.birth_date = reader.GetDateTime(5);
            return student;
        }
        public new static void Update(StudentActiveRecord updatedStudent, SqlConnection connection)
        {
            Update(updatedStudent);
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("UPDATE Student_DDM");
            sb.Append("SET first_name = @first_name,last_name=@last_name,email=@email,phone_number=@phone_number,birth_date=birth_date");
            sb.Append("WHERE student_id=@stundent_id");
            string sql = sb.ToString();
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@first_name", updatedStudent.first_name);
                command.Parameters.AddWithValue("@last_name", updatedStudent.last_name);
                command.Parameters.AddWithValue("@email", updatedStudent.email);
                command.Parameters.AddWithValue("@phone_number", updatedStudent.phone_number);
                command.Parameters.AddWithValue("@birth_date", updatedStudent.birth_date);
                command.ExecuteNonQuery();
            }
        }
        public static StudentActiveRecord FindByEmail(String email, SqlConnection connection)
        {
            StudentActiveRecord student = default(StudentActiveRecord);
            string sql = "SELECT * FROM Student_DDM WHERE email = @email;";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@email", email);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        student = MapResultsetToObject(reader);
                    }
                }
            }

            if (student != default(StudentActiveRecord))
            {
                StudentActiveRecord osoba2 = Get(student.ID);

                if (osoba2 == default(StudentActiveRecord))
                {
                    Add(student);
                }
            }

            return student;
        }

    }
}
