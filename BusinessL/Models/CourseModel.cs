using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs;
using DataLayer.TableDataGateway;
namespace BusinessL.Models
{
    public class CourseModel
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public char difficulty { get; set; }

        public int capacity { get; set; }

        public int classroomID { get; set; }

        public CourseModel(Course course)
        {
            courseId = course.courseId;
            courseName = course.courseName;
            difficulty = course.difficulty;
            capacity = course.capacity;
            classroomID = course.classroomID;
        }
        public Course ToDTO()
        {
            var course = new Course
            {
                courseId = courseId,
                courseName = courseName,
                difficulty = difficulty,
                capacity = capacity,
                classroomID = classroomID
            };
            return course; 
        }
    }
}
