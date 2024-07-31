using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AIRPORT.Models
{
    public class FlightNumber
    {

        public string FlightID { get; }
        public string fArrivalAirPort { get; }
        public string fDepartureAirPort { get; }

        public FlightNumber(string flightID, string fArrivalAirPort, string fDepartureAirPort)
        {
            FlightID = flightID;
            this.fArrivalAirPort = fArrivalAirPort;
            this.fDepartureAirPort = fDepartureAirPort;
        }

        public override bool Equals(object obj)
        {
            return obj is FlightNumber flightNumber && fArrivalAirPort == flightNumber.fArrivalAirPort && fDepartureAirPort == flightNumber.fDepartureAirPort; 
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(fArrivalAirPort, fDepartureAirPort);
        }
        public override string ToString()
        {
            return $"{fArrivalAirPort},{fDepartureAirPort}";
        }

        public static bool operator == (FlightNumber Fn1, FlightNumber Fn2) 
        {
           if(Fn1 is null && Fn2 is null)
            {
                return true;
            }

            return !(Fn1 is null) && Fn1.Equals(Fn2);
        }

        public static bool operator !=(FlightNumber Fn1, FlightNumber Fn2)
        {
           return !(Fn1 == Fn2); 
        }
    }
}
