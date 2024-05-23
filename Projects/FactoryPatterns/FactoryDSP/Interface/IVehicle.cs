using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDSP.Interface
{
    public interface IVehicle
    {
        public int NumberOfWheels();
        public string VehicleType();
    }
}
