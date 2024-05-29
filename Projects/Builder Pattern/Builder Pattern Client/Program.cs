using Builder_Design_Pattern.Concrete_Builder;
using Builder_Design_Pattern.Director;
using Builder_Design_Pattern.Interfaces;
using Builder_Design_Pattern.Model;

namespace Builder_Pattern_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DesktopDirector director = new DesktopDirector(new HPBuilder());
            director.CreateDesktop();
            Desktop desktop = director.GetDesktop();

            Console.WriteLine(desktop.Motherboard + '\n' +
                              desktop.Monitor + '\n' + 
                              desktop.Keyboard + '\n' +
                              desktop.Mouse + '\n' +
                              desktop.Processor + '\n' +
                              desktop.Graphics + '\n' +
                              desktop.Storage);
        }
    }
}
