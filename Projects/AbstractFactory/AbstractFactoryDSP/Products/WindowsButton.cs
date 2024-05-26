using AbstractFactoryDSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDSP.Products
{
    public class WindowsButton : IButton
    {
        public void Press()
        {
            Console.WriteLine("Windows Button is Pressed");
        }
    }
}
