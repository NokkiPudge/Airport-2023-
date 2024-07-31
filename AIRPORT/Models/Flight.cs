using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRPORT.Models
{
   public class Flight
    {
        private readonly RegistrationBook _registrationBook;
        public string Name { get; set; }
        public Flight(string name)
        {
            name = Name;
            _registrationBook = new RegistrationBook();
        }
    }
}
