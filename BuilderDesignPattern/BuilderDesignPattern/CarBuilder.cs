using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class CarBuilder
    {
        public string Roof { get; set; }
        public string Door { get; set; }
        public string Wheels { get; set; }
        public string Seats { get; set; }
        public CarBuilder SetRoof(string roof)
        {
            Roof = roof;
            return this;
        }
        public CarBuilder SetDoor(string door)
        {
            Door = door;
            return this;
        }
        public CarBuilder SetWheels(string wheels)
        {
            Wheels = wheels;
            return this;
        }
        public CarBuilder SetSeats(string seats)
        {
            Seats = seats;
            return this;
        }
        public Car BuildCar()
        {
            return new Car(Roof, Door, Wheels, Seats);
        }
    }
}
