using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDSP.Interfaces
{
    public interface IFactory
    {
        public ILogger CreateObject();
    }
}
