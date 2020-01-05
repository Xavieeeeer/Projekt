using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs;
using DataLayer.TableDataGateway;

namespace BusinessL.Models
{
    public class LectorModel
    {
        public int lectorID { get; set; }
        public string firstName { get; set; }
        public string lastnName { get; set; }
        public int phoneNumber { get; set; }
        public string email { get; set; }


        public LectorModel(Lector lector)
        {
            lectorID = lector.lectorID;
            firstName = lector.firstName;
            lastnName = lector.lastnName;
            phoneNumber = lector.phoneNumber;
            email = lector.email;
        }

        public Lector ToDTO()
        {
            Lector lector = new Lector
            {
                lectorID = lectorID,
                firstName = firstName,
                lastnName = lastnName,
                phoneNumber = phoneNumber,
                email = email
            };
            return lector;
        }
    }
}
