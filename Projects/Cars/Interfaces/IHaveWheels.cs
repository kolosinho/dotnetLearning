using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal interface IHaveWheels
    {
        //правильно подвязать массив колес к интерфейсу IWheel, а не к классу Wheel
        public Wheel[] Wheels { get; set; }
    }
}
