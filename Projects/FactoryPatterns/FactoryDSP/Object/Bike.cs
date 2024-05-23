using FactoryDSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDSP.Object
{
    public class Bike : IVehicle
    {
        public int Wheels { get; set; }
        public Bike()
        {
            Wheels = 2;
        }
        public int NumberOfWheels()
        {
            return Wheels;
        }

        public string VehicleType()
        {
            return "Bike";
        }
    }
}
