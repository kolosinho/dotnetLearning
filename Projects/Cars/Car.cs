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


            //wheels cheking
            if (wheels == null)
            {
                throw new Exception("There are no wheels to build a car.");
            }
            else if (wheels.Length < 4 || wheels.Length > 4)
            {
                throw new Exception($"Four(4) wheels are required to build a car. Total wheels: {wheels.Length}");
            }
            
            for (int i = 1; i < 4; i++)
            {
                if (wheels[i].Size != wheels[0].Size)
                {
                    throw new Exception("The size of the wheels must be the same to build a car!");
                }
            }

            //doors cheking
            if (doors == null)
            {
                throw new Exception("There are no wheels to build a car.");
            }
            else if (doors.Length < 4 || doors.Length > 4)
            {
                throw new Exception($"Four(4) doors are required to build a car. Total doors: {doors.Length}");
            }

            for (int i = 1; i < 4; i++)
            {
                if (doors[i].DoorType != doors[0].DoorType)
                {
                    throw new Exception("The type of doors must be the same to build a car!");
                }
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

        public void GetCarStatus()
        {
            Console.WriteLine($"{Engine.GetEngineStatus()}\n" +
                $"Current speed: {currentSpeed} km/h.\n" +
                $"The amount of max speed reached: {amountOfMaxSpeedReached}, the engine will be broken if reach it 3 times!");
        }

        private int currentSpeed = 0;
        private int amountOfMaxSpeedReached = 0;

        public void Move(int speed)
        {
            if (Engine.EngineStatus == Engine.EngineStatusCodes.Off)
            {
                Console.WriteLine("The cars engine must be started for moving.");
            }
            else if(Engine.EngineStatus == Engine.EngineStatusCodes.On && speed <= 0)
            {
                Console.WriteLine("The car cannot move backward or stand still");
            }
            else if (Engine.EngineStatus == Engine.EngineStatusCodes.On && speed >= 0 && speed <= MaxSpeed)
            {
                currentSpeed = speed;
                Console.WriteLine($"The car has been successfully accelerated to the next speed: {speed} km/h.");
            }
            else if (Engine.EngineStatus == Engine.EngineStatusCodes.On && speed > MaxSpeed && amountOfMaxSpeedReached < 2)
            {
                currentSpeed = MaxSpeed;
                amountOfMaxSpeedReached++;
                Console.WriteLine($"The car has accelerated to maximum speed: {MaxSpeed} km/h, but the condition of the engine has been worsened.");
            }
            else
            {
                Engine.ChangeEngineStatus(Engine.EngineStatusCodes.Broken);
                currentSpeed = 0;
                amountOfMaxSpeedReached = 3;
                Console.WriteLine("You have reached the maximum speed more than 3 times, the engine has been broken.");
            }                      
        }

        public void StartEngine()
        {
            if (Engine.EngineStatus == Engine.EngineStatusCodes.Off)
            {
                Engine.ChangeEngineStatus(Engine.EngineStatusCodes.On);
                Console.WriteLine("The engine has started.");
            }
            else if (Engine.EngineStatus == Engine.EngineStatusCodes.Broken)
            {
                Console.WriteLine("The engine is broken.");
            }
            else
            {
                Console.WriteLine("The engine is already started");
            }
        }

        public void StopEngine()
        {
            if (Engine.EngineStatus == Engine.EngineStatusCodes.On)
            {
                Engine.ChangeEngineStatus(Engine.EngineStatusCodes.Off);
                currentSpeed = 0;
                amountOfMaxSpeedReached = 0;
                Console.WriteLine("The engine has stopped.");
            }
            else 
            {
                Console.WriteLine("The engine is already stopped.");
            }
        }

        //Переопределенный метод ToString
    }
}
