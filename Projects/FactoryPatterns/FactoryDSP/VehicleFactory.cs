using FactoryDSP.Interface;
using FactoryDSP.Object;

namespace FactoryDSP
{
    public class VehicleFactory
    {
        public static IVehicle? GetVehicle(string type)
        {
            var vehicleType = type.ToLower();
            switch (vehicleType)
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                case "autorickshaw":
                    return new AutoRickshaw();
                default:
                    return null;
            }
        }
    }
}
