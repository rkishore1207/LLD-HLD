using AbstractFactoryDSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDSP.Products
{
    public class MacTextBox : ITextBox
    {
        public void SetText()
        {
            Console.WriteLine("Mac Text box is created");
        }
    }
}
