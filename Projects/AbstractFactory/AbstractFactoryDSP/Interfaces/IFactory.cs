using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDSP.Interfaces
{
    public interface IFactory
    {
        public IButton CreateButton();
        public ITextBox CreateTextBox();
    }
}
