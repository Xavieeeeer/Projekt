using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs;
using DataLayer.TableDataGateway;
namespace BusinessL.Models
{
    public class StudentModel
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastnName { get; set; }
        public int phoneNumber { get; set; }
        public string email { get; set; }
        public DateTime birhtDate { get; set; }

        public StudentModel(Student student)
        {
            studentID = student.studentID;
            firstName = student.firstName;
            lastnName = student.lastnName;
            phoneNumber = student.phoneNumber;
            email = student.email;
            birhtDate = student.birhtDate;
        }
        public Student ToDTO()
        {
            var student = new Student()
            {
                studentID = studentID,
                firstName = firstName,
                lastnName = lastnName,
                phoneNumber = phoneNumber,
                email = email,
                birhtDate = birhtDate
            };
            return student;
        }
    }
}
