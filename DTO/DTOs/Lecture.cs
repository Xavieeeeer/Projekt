using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.DTOs
{
    public class Lecture
    {
        public int lectureiD { get; set; }
        public string theme { get; set; }
        public DateTime dateLecture { get; set; }
        public int courseID { get; set; }
    }
}
