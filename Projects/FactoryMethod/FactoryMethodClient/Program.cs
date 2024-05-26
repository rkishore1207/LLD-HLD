using FactoryMethodDSP.Interfaces;
using FactoryMethodDSP.Objects.Factories;

namespace FactoryMethodClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.Write("Please Enter 1 -> Debug, 2 -> Info, 3 -> Error: ");
            var value = Console.ReadLine();
            if(value != null && (value == "1" || value == "2" || value == "3"))
                number = Convert.ToInt32(value);
            IFactory factory = null;
            switch (number)
            {
                case 1:
                    factory = new DebugLogFactory();
                    break;
                case 2:
                    factory = new InfoLogFactory();
                    break;
                case 3:
                    factory = new ErrorLogFactory();
                    break;
                default:
                    Console.WriteLine("Please enter valid number");
                    break;

            }
            if(factory != null)
            {
                ILogger logger = factory.CreateObject();
                logger.GetLogType();
            }
        }
    }
}
