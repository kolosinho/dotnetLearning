using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Sedan : Car
    {
        public Sedan(CarManufactor manufactor, string model, Colors color, Engine engine, int maxSpeed, Door[] doors, Wheel[] wheels) 
            : base(manufactor, model, color, engine, maxSpeed, doors, wheels)
        {
        }
        public override CarType Type { get; } = CarType.Sedan;
    }
}
