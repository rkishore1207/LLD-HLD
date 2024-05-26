using AbstractFactoryDSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDSP.Products.Factories
{
    public class AbstractFactory
    {
        public string OSType { get; set; }
        public AbstractFactory(string osType) 
        {
            OSType = osType;
        }

        public IFactory CreateFactory()
        {
            switch (OSType.ToLower())
            {
                case "windows":
                    return new WindowsFactory();
                case "mac":
                    return new MacFactory();
                default:
                    return null;
            }
        }
    }
}
