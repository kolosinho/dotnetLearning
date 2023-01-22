using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public enum DoorTypes
    {
        Conventional,
        Sliding,
        Butterfly,
        Raptor,
        Swan,
        Canopy
    }

    public class Door
    {
        public Door(DoorTypes doorType, string modelName)
        {
            this.DoorType = doorType;
            this.ModelName = modelName;
        }
        public DoorTypes DoorType { get; set; }
        public string ModelName { get; set; }

    }
}
