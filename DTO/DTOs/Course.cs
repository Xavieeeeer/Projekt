using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.DTOs
{
    public class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public char difficulty { get; set; }

        public int capacity { get; set; }

        public int classroomID { get; set; }
    }
}
