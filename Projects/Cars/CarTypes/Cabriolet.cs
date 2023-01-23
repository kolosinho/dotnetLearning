using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Cabriolet : Car
    {
        public Cabriolet(CarManufactor manufactor, string model, Colors color, Engine engine, int maxSpeed, Door[] doors, Wheel[] wheels)
            : base(manufactor, model, color, engine, maxSpeed, doors, wheels){}

        public override CarType Type { get; } = CarType.Cabriolet;
       
        private bool isRoofUp; //isRoofUp = true -> the roof is open, false -> the roof is down

        public bool IsRoofUp { get { return isRoofUp; } }

        public void RoofUp()
        {
            if (isRoofUp == false)
            {
                isRoofUp = true;
                Console.WriteLine("The roof is up now");
            }
            else
            {
                Console.WriteLine("The roof is already up");
            }
            
        }

        public void RoofDown()
        {
            if (isRoofUp == true)
            {
                isRoofUp = false;
                Console.WriteLine("The roof is down now");
            }
            else
            {
                Console.WriteLine("The roof is already down");
            }
        }

        public string GetRoofStatus()
        {
            return isRoofUp == false ? "The roof is down" : "The roof is up";
        }
    }
}
