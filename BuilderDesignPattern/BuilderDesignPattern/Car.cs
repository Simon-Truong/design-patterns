using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Car
    {
        public string Roof { get; set; }
        public string Door { get; set; }
        public string Wheels { get; set; }
        public string Seats { get; set; }
        public Car(string roof, string door, string wheels, string seats)
        {
            Roof = roof;
            Door = door;
            Wheels = wheels;
            Seats = seats;
        }
        public string GetRoof()
        {
            return Roof;
        }
        public string GetDoor()
        {
            return Door;
        }
        public string GetWheels()
        {
            return Wheels;
        }
        public string GetSeats()
        {
            return Seats;
        }
    }
}
