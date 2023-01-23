using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        public enum EngineStatusCodes
        {
            On,
            Off,
            Broken
        }

        private readonly Dictionary<EngineStatusCodes, string> StatusCodeMessages = new Dictionary<EngineStatusCodes, string>()
        {
            { EngineStatusCodes.On, "The engine status: ON." },
            { EngineStatusCodes.Off,"The engine status: OFF."},
            { EngineStatusCodes.Broken,"The engine status: BROKEN."}
        };

        private EngineStatusCodes engineStatus = EngineStatusCodes.Off;
        public EngineStatusCodes EngineStatus { get { return engineStatus; } }

        public void ChangeEngineStatus(EngineStatusCodes newStatus)
        {
            engineStatus = newStatus;
        }

        public string GetEngineStatus()
        {
            return StatusCodeMessages[engineStatus];
        }
        public override string ToString()
        {
            return $"----------Engine info:----------" + "\n" +
            $"Manufactor: {Manufactor}." + "\n" +
                $"Capacity: {Capacity}L." + "\n" +
                $"Cylinders: {Cylinders}." + "\n" +
                $"Horse powers: {HorsePowers}.";
        }
    }
}
