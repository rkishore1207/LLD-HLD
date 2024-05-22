using FactoryDSP;
using FactoryDSP.Interface;

namespace SimpleFactoryCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the type of Vehicle which you want to create : ");
            string type = "";
            while (true)
            {
                type = Console.ReadLine();
                if (type != null && (type == "car" || type == "bike" || type == "autorickshaw"))
                    break;
                else
                    Console.Write("Please give -> car or bike or autorickshaw: ");
            }
            IVehicle? vehicle = VehicleFactory.GetVehicle(type);
            Console.WriteLine("Wheels: " + vehicle?.NumberOfWheels().ToString());
            Console.WriteLine("Vehicle: " + vehicle?.VehicleType());
        }
    }
}
