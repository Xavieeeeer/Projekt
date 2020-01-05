using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs;
using DataLayer.TableDataGateway;
namespace BusinessL.Models
{
    public class LectureModel
    {
        public int lectureID { get; set; }
        public string theme { get; set; }
        public DateTime dateLecture { get; set; }
        public int courseID { get; set; }

        public LectureModel(Lecture lecture)
        {
            lectureID = lecture.lectureiD;
            theme = lecture.theme;
            dateLecture = lecture.dateLecture;
            courseID = lecture.courseID; 
        }
        public Lecture ToDTO()
        {
            var lecture = new Lecture
            {
                lectureiD = lectureID,
                theme = theme,
                dateLecture = dateLecture,
                courseID = courseID
            };
            return lecture;
        }
    }
}
