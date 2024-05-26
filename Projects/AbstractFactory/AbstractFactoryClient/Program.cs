using AbstractFactoryDSP.Interfaces;
using AbstractFactoryDSP.Products.Factories;

namespace AbstractFactoryClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new AbstractFactory("Mac").CreateFactory();
            IButton button =  factory.CreateButton();
            button.Press();
            ITextBox textBox = factory.CreateTextBox();
            textBox.SetText();
        }
    }
}
