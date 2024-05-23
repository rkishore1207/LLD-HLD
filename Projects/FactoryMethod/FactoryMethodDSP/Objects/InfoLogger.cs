using FactoryMethodDSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDSP.Objects
{
    public class InfoLogger : ILogger
    {
        public void GetLogType()
        {
            Console.WriteLine("Created Info Log Object");
        }
    }
}
