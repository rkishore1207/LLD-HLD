using AbstractFactoryDSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDSP.Products
{
    public class WindowsTextBox : ITextBox
    {
        public void SetText()
        {
            Console.WriteLine("Set Text for Windows");
        }
    }
}
