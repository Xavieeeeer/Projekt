using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.DTOs
{
    public class Classroom
    {
        public int classroomID { get; set; }
        public int floorNumber { get; set; }
        public int roomNumber { get; set; }
        public int capacity { get; set; }
        public char computer { get; set; }
    }
}
