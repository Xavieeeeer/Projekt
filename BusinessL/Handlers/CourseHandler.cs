using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using BusinessL.Models;
using DTO.DTOs;
using DataLayer.TableDataGateway;
using System.Data.SqlClient;
namespace BusinessL.Handlers
{
    public class CourseHandler
    {
        public static Collection<CourseModel> Select(SqlConnection connection)
        {
            var courses = CourseDataGateway.Select(connection);
            var courseModels = new Collection<CourseModel>();
            foreach (var course in courses)
            {
                courseModels.Add(new CourseModel(course));
            }
            return courseModels;
        }
    }
}
