using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public enum CarManufactor
    {
        BMW,
        Mercedes,
        Ford,
        Audi,
        Ferrari,
        Lamborgini
    }

    public enum CarType
    {
        Sedan,
        Offroad,
        Cabriolet
    }

    public enum Colors
    {
        Red,
        Black,
        White,
        Yellow,
        Blue
    }

    public abstract class Car : ICanMove, IHaveWheels
    {
        public Car(CarManufactor manufactor, string model, Colors color, Engine engine, int maxSpeed, Door[] doors, Wheel[] wheels)
        {
            this.Manufactor = manufactor;
            this.Model = model;
            this.Color = color;
            this.Engine = engine;
            this.MaxSpeed = maxSpeed;
            this.Doors = doors;
            this.Wheels = wheels;

            if (wheels == null)
            {
                throw new Exception("There are no wheels to build a car.");
            }
            else if (wheels.Length < 4 || wheels.Length > 4)
            {
                throw new Exception($"Four(4) wheels are required to build a car. Total wheels: {wheels.Length}");
            }

        }

        public readonly CarManufactor Manufactor;

        public readonly string Model;

        public abstract CarType Type { get; }

        public Colors Color { get; set; }

        public Engine Engine { get; set; }  

        public int MaxSpeed { get; set; }

        public Door[] Doors { get; set; }

        public Wheel[] Wheels { get; set; }

        //public Dictionary<string, string> carStatus = new Dictionary<string, string>()
        //{
        //    ["Car status:"] = "Car is not moving",
        //    ["Engine status"] = "OFF",
        //    ["Engine failure"] = "false",
        //    ["Amount of speed limit reached"] = "Car is not moving"
        //}
        //;


        public string Move(int speed)
        {
            //if (carstatus["engine status"] == "on" && speed <= 0)
            //{
            //    return "the car cannot move backward or stand still";
            //}
            //else if (speed > maxspeed) {

            //}
            //else
            //{

            //}
            return "car speed";
                      
        }
        public string status()
        {
            return "Car status";
        }

        public string startEngine()
        {
            return "Engine has started";
        }

        public string stopEngine()
        {
            return "Engine has stopped";
        }

        //Переопределенный метод ToString
    }
}
