using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRPORT.Models
{
    public class Registration
    {
        public string UserName { get; set; }
        public int PassportNumber { get; set; }
        public string Phone { get; set; }
        public Route RegRoute { get; set; }

        //public Registration(string userName, int passportNumber, string phone, Route route)
        //{
        //    UserName = userName;
        //    PassportNumber = passportNumber;
        //    Phone = phone;
        //    RegRoute = route;
        //}

        //public Registration()
        //{
            
        //}



    }
}
