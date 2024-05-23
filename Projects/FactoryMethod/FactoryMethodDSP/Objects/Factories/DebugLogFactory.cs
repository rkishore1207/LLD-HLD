using FactoryMethodDSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDSP.Objects.Factories
{
    public class DebugLogFactory : IFactory
    {
        public ILogger CreateObject()
        {
            return new DebugLogger();
        }
    }
}
