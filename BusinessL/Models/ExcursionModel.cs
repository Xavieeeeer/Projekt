using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs;
using DataLayer.TableDataGateway;

namespace BusinessL.Models
{
    public class ExcursionModel
    {
        public int excursionID { get; set; }
        public DateTime dateExcursion { get; set; }

        public float cost { get; set; }

        public int courseID { get; set; }

        public ExcursionModel(Excursion excursion)
        {
            excursionID = excursion.excursionID;
            dateExcursion = excursion.dateExcursion;
            cost = excursion.cost;
            courseID = excursion.courseID;
        }

        public Excursion ToDTO()
        {
            var excursion = new Excursion()
            {
                excursionID = excursionID,
                dateExcursion = dateExcursion,
                cost = cost,
                courseID = courseID
            };
            return excursion;
        }
    }
}
