using System;

namespace Cars
{
    class MyHomeTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Wheels--------");

            Wheel firstWheel = new Wheel(WheelsManufactor.Apollo, "SuperWheel", 21);
            Wheel secondWheel = new Wheel(WheelsManufactor.Apollo, "SuperWheel", 21);

            Wheel[] wheels = null;

            Console.WriteLine(firstWheel.Manufactor.ToString() + " " + firstWheel.ModelName + " " + firstWheel.Size + "\n");

            Console.WriteLine("-------Doors--------");

            Door firstDoor = new Door(DoorTypes.Sliding, "Ferrari");

            Door[] doors = new Door[] { firstDoor };

            Console.WriteLine(firstDoor.DoorType.ToString() + " " + firstDoor.ModelName + "\n");

            Console.WriteLine("-------Engine--------");

            Engine carEngine = new Engine(EngineManufactor.BMW, 3.8, EngineCylinders.V6, 645);

            Console.WriteLine(carEngine.Manufactor.ToString() + " " + carEngine.Capacity + " " + carEngine.Cylinders + " " + carEngine.HorsePowers + "\n");

            Console.WriteLine("-------Cars--------");
           
            // Sedan creation

            Sedan Sedan = new Sedan(CarManufactor.BMW, "M5", Colors.Red, carEngine, 400, doors, wheels);

            Console.WriteLine(Sedan.Manufactor.ToString() + " " + Sedan.Model + " " + Sedan.Type.ToString() + " " + Sedan.Color.ToString()
                + " " + Sedan.Engine.HorsePowers + " " + Sedan.MaxSpeed);

            // Offroad creation


            Offroad Offroad = new Offroad(CarManufactor.Ford, "F-150", Colors.Blue, carEngine, 320, doors, wheels);

            Console.WriteLine(Offroad.Manufactor.ToString() + " " + Offroad.Model + " " + Offroad.Type.ToString() + " " + Offroad.Color.ToString()
               + " " + Offroad.Engine.HorsePowers + " " + Offroad.MaxSpeed);

            // Cabriolet creation

            Cabriolet Cabriolet = new Cabriolet(CarManufactor.Mercedes, "AMG 4", Colors.White, carEngine, 420, doors, wheels);

            Console.WriteLine(Cabriolet.IsRoofUp);

            Console.WriteLine(Cabriolet.Manufactor.ToString() + " " + Cabriolet.Model + " " + Cabriolet.Type.ToString() + " " + Cabriolet.Color.ToString()
                + " " + Cabriolet.Engine.HorsePowers + " " + Cabriolet.MaxSpeed + " " + Cabriolet.GetRoofStatus());
        }
    }
}