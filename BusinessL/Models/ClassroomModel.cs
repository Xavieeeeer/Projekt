using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs;
using DataLayer.TableDataGateway;
namespace BusinessL.Models
{
    public class ClassroomModel
    {
        public int classroomID { get; set; }
        public int floorNumber { get; set; }
        public int roomNumber { get; set; }
        public int capacity { get; set; }
        public char computer { get; set; }


        public ClassroomModel(Classroom classroom)
        {
            classroomID = classroom.classroomID;
            floorNumber = classroom.floorNumber;
            roomNumber = classroom.roomNumber;
            capacity = classroom.capacity;
            computer = classroom.computer;
        }
        public Classroom ToDTO()
        {
            var classroom = new Classroom()
            {
                classroomID = classroomID,
                floorNumber = floorNumber,
                roomNumber = roomNumber,
                capacity = capacity,
                computer = computer
            };
            return classroom;
        }
    }
}
