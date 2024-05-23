using FactoryMethodDSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDSP.Objects
{
    public class DebugLogger : ILogger
    {
        public void GetLogType()
        {
            Console.WriteLine("Created Debug Log Object");
        }
    }
}
