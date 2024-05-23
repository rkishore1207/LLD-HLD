using FactoryDSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDSP.Object
{
    public class AutoRickshaw : IVehicle
    {
        public int Wheels { get; set; }
        public AutoRickshaw()
        {
            Wheels = 3;
        }
        public int NumberOfWheels()
        {
            return Wheels;
        }
        public string VehicleType()
        {
            return "Auto Rickshaw";
        }
    }
}
