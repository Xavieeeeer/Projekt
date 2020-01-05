using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.DTOs
{
    public class Excursion
    {
        public int excursionID { get; set; }
        public DateTime dateExcursion { get; set; }

        public float cost { get; set; }

        public int courseID { get; set; }
    }
}
