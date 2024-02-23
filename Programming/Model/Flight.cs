using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTime;

        public string DeparturePoint { get; set; }
        public string Destination { get; set; }

        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _flightTime = value;
            }
        }

        public Flight(string departurePoint, string destination, int flightTime)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
        }
    }
}
