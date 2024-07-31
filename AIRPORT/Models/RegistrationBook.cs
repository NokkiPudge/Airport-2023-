using AIRPORT.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRPORT.Models
{
    public class RegistrationBook
    {
        private readonly List<Registration> _registrations;

        public RegistrationBook()
        {
            _registrations = new List<Registration>();  
        }   
    }
}
