using AIRPORT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AIRPORT.Exceptions
{
    public class RegistrationConflictException : Exception
    {
        public Registration ExistingRegistration { get; }
        public Registration IncomingRegistration { get; }

        public RegistrationConflictException(Registration existingRegistration, Registration incomingRegistration)
        {
            ExistingRegistration = existingRegistration;
            IncomingRegistration = incomingRegistration;
        }

        public RegistrationConflictException(string message, Registration existingRegistration, Registration incomingRegistration) : base(message)
        {
            ExistingRegistration = existingRegistration;
            IncomingRegistration = incomingRegistration;
        }

        public RegistrationConflictException(string message, Exception innerException, Registration existingRegistration, Registration incomingRegistration) : base(message, innerException)
        {
            ExistingRegistration = existingRegistration;
            IncomingRegistration = incomingRegistration;
        }


    }
}
