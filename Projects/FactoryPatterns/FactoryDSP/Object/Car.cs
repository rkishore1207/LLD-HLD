using FactoryDSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDSP.Object
{
    public class Car : IVehicle
    {
        public int Wheels { get; set; }
        public Car() 
        {
            Wheels = 4;
        }
        public int NumberOfWheels()
        {
            return Wheels;
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
}
