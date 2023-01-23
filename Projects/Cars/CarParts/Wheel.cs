using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public enum WheelsManufactor
    {
        Michelin,
        Apollo,
        Fireston,
        Riken
    }

    public class Wheel
    {
        public Wheel(WheelsManufactor manufactor, string modelName, int size)
        {
            this.Manufactor = manufactor;
            this.ModelName = modelName;
            this.Size = size;
        }
        public WheelsManufactor Manufactor { get; set; }
        public string ModelName { get; set; }

        public int Size { get; set; }
        public override string ToString()
        {
            return $"----------Wheels info:----------" + "\n" +
            $"Manufactor: {Manufactor}." + "\n" +
                $"Model name: '{ModelName}'." + "\n" +
                $"Size: {Size}.";
        }
    }
}
