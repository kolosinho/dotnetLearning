using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public enum EngineManufactor
    {
        Ford,
        Mercedes,
        BMW,
        VW
    }

    public enum EngineCylinders
    {
        V4,
        V6,
        V8,
        V12
    }

    public class Engine
    {
        public Engine(EngineManufactor manufactor, double capacity, EngineCylinders cylinders,int horsePowers)
        {
            this.Manufactor = manufactor;
            this.Capacity = capacity;
            this.Cylinders= cylinders;
            this.HorsePowers = horsePowers;
        }
        public EngineManufactor Manufactor { get; set; }
        public double Capacity { get; set; }
        public EngineCylinders Cylinders { get; set; }
        public int HorsePowers { get; set; }
    }
}
